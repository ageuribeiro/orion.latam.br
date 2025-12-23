from abc import ABC, abstractmethod
from .entities import User

class UserRepositoryPort(ABC):
    @abstractmethod
    def save(self, user_id: int) -> User:
        pass
