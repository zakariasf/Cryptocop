class CreditCardValidator():
    ''' Credit card validator that uses the luhn algorithm to validate credit cards'''
    def __sum_digits(self, digit):
        if digit < 10:
            return digit
        else:
            sum = (digit % 10) + (digit // 10)
            return sum


    def validate(self, cc_num):
        # reverse the credit card number
        cc_num = cc_num[::-1]
        # convert to integer list
        cc_num = [int(x) for x in cc_num]
        # double every second digit
        doubled_second_digit_list = list()
        digits = list(enumerate(cc_num, start=1))
        for index, digit in digits:
            if index % 2 == 0:
                doubled_second_digit_list.append(digit * 2)
            else:
                doubled_second_digit_list.append(digit)

        # add the digits if any number is more than 9
        doubled_second_digit_list = [self.__sum_digits(x) for x in doubled_second_digit_list]
        # sum all digits
        sum_of_digits = sum(doubled_second_digit_list)
        # return True or False
        return sum_of_digits % 10 == 0



if __name__ == "__main__":
    validator = CreditCardValidator()
    print(validator.validate("5333619503715702"))
