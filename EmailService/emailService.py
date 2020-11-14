import pika
import json

from emailSender import EmailSender

connection = pika.BlockingConnection(pika.ConnectionParameters('localhost'))
channel = connection.channel()

exchange_name = 'order-creation-exhange'
input_routing_key = 'create-order'
email_queue_name = 'email-queue'

# Declare exchange
channel.exchange_declare(exchange=exchange_name, exchange_type='direct', durable=True)

# Declare queue
channel.queue_declare(queue=email_queue_name, durable=True)

# Bind queue to exchange with a routing key
channel.queue_bind(queue=email_queue_name, exchange=exchange_name, routing_key=input_routing_key)

email_sender = EmailSender()

def order_to_html(order):
    return f''' 
    <h1>Order:</h1>
    <p>Name of customer: {order["FullName"]}</p>
    <p>Street name and number: {order["StreetName"]} {order["HouseNumber"]}</p>
    <p>City: {order["City"]}</p>
    <p>Zip code: {order["ZipCode"]}</p>
    <p>Country: {order["Country"]}</p>
    <p>Date of order: {order["OrderDate"]}</p>
    <p>Total price: {order["TotalPrice"]}</p>
    <p>Order items: {order["OrderItems"]}</p>
    '''

def on_order_consumed(ch, method, properties, data):
    order = json.loads(data)
    is_successful = email_sender.send_email("Order created", order_to_html(order), order["Email"])
    print("Was email successful:", is_successful)

channel.basic_consume(consumer_callback=on_order_consumed,
                      queue=email_queue_name,
                      no_ack=True)

channel.start_consuming()
connection.close()