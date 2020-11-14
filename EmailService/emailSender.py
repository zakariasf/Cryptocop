import requests

class EmailSender():
    def __init__(self) -> None:
        self.__private_api_key = "7af8c98b9dd3174bfc5c3c1fa1a84d6b-ba042922-ff43f321"
        self.__domain = "sandbox822783c3ab6340eda1ab31cda3239909.mailgun.org"



    def send_email(self,subject ,html_body, email_to):
        response =  requests.post(
        f"https://api.mailgun.net/v3/{self.__domain}/messages",
        auth=("api", self.__private_api_key),
        data={"from": f"Mailgun sandbox <mailgun@{self.__domain}>",
              "to": [email_to],
              "subject": subject,
              "html": html_body})
        return response.ok



if __name__ == "__main__":
    email_sender = EmailSender()
    html_body = ''' 
    <h1>Order:</h1>
    <p>Name of customer: blabla</p>
    <p>Street name and number: blabla</p>
    <p>City: blabla</p>
    <p>Zip code: blabla</p>
    <p>Country: blabla</p>
    <p>Date of order: blabla</p>
    <p>Total price: blabla</p>
    <p>Order items: blabla</p>
    '''
    bla = email_sender.send_message("test subject", html_body, "zakarias18@ru.is")
    print(bla)