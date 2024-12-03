from threading import Thread
import socket

class cfg:
	host = '0.0.0.0'
	port = 65535

def start_server():
	with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
		s.bind((cfg.host, cfg.port))
		s.listen()
		print(f"Сервер запущен {cfg.host}:{cfg.port}")
		conn, addr = s.accept()
		Thread(target=lambda:client_handler(conn,addr)).start()


def client_handler(conn, addr):
	with conn:
		print(f"Подключено к {addr}")
		while True:
			data = conn.recv(1024).decode()
			if data == "exit": break
		print(f"Получено: {data}")
		conn.sendall(data)

if __name__ == '__main__':
    start_server()
