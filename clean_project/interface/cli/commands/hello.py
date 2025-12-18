from application.use_cases.hello_use_case import HelloUseCase

def hello_command():
    use_case = HelloUseCase()
    message = use_case.execute()
    print(message)
    