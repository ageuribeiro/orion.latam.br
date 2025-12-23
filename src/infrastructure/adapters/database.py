from src.domain.entities import User
from src.domain.ports import UserRepositoryPort

class InMemoryUserRepository(UserRepositoryPort):
    def __init__(self):
        self.users = {}
        self._next_id = 1

    def save(self, user: User) -> User:
        user.id = self._next_id
        self.users[user.id] = user
        self._next_id += 1
        return user