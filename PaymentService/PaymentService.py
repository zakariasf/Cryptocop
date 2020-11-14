import pika
import json

from CreditCardValidator import CreditCardValidator

connection = pika.BlockingConnection(pika.ConnectionParameters('localhost'))
channel = connection.channel()

exchange_name = 'order-creation-exhange'
input_routing_key = 'create-order'
payment_queue_name = 'payment-queue'

# Declare exchange
channel.exchange_declare(exchange=exchange_name, exchange_type='direct', durable=True)

# Declare queue
channel.queue_declare(queue=payment_queue_name, durable=True)

# Bind queue to exchange with a routing key
channel.queue_bind(queue=payment_queue_name, exchange=exchange_name, routing_key=input_routing_key)

cc_validator = CreditCardValidator()

def on_order_consumed(ch, method, properties, data):
    order = json.loads(data)
    is_card_valid = cc_validator.validate(order["CreditCard"])
    print(f'Data received: {order}, valid: {is_card_valid}')

channel.basic_consume(on_message_callback=on_order_consumed,
                      queue=payment_queue_name,
                      auto_ack=True)

channel.start_consuming()
connection.close()