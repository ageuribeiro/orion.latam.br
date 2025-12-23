from src.domain.entities import User
from src.domain.ports import UserRepositoryPort

class CreateUserUseCase:
    def __init__(self, user_repository: UserRepositoryPort):
        self.user_repository = user_repository

    def execute(self, username: int, email:str) -> User:
        user = User(id=None, username=username, email=email)
        return self.user_repository.save(user)