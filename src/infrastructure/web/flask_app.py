import os
from flask import Flask, jsonify, request, render_template
from src.application.use_cases import CreateUserUseCase
from src.infrastructure.adapters.database import InMemoryUserRepository

current_dir = os.path.dirname(os.path.abspath(__file__))    

app = Flask(__name__, template_folder=os.path.join(current_dir, 'templates'), static_folder=os.path.join(current_dir, 'static'))

repo = InMemoryUserRepository()
create_user_use_case = CreateUserUseCase(user_repository=repo)

@app.route('/')
def home():
    return render_template('index.html')

@app.route('/users', methods=['POST'])
def create_user():
    data = request.json
    new_user = create_user_use_case.execute(
        usename=data['username'],
        email=data['email']
    )
    return jsonify({'id': new_user.id, 'username': new_user.username, 'email': new_user.email}), 201

# if __name__ == '__main__':
#     app.run(debug=True)