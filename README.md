# DiSUcord - A Chat Application

DiSUcord is a messaging networking application that emulates the basic functionalities of Discord. This project is divided into two main modules: the Server module, which manages messages and channels, and the Client module, which allows users to subscribe to channels, send messages, and view messages in the subscribed channels.

## Features

- **Server Module**: Manages client connections, channels, and message multicasting.
- **Client Module**: Supports subscribing to channels, sending and viewing messages.
- **Real-Time Communication**: Ensures real-time message exchange between clients.
- **Channel Management**: Includes two fixed channels, "IF 100" and "SPS 101".
- **Unique Client Identification**: Clients connect using unique usernames.
- **Dynamic Port Configuration**: Server port is configurable through the Server GUI.
- **Multicasting of Messages**: Server explicitly sends messages only to subscribed clients of a channel.
- **GUI for Monitoring**: Server and client activities are displayed on respective GUIs.

## Running the Application

### Server

1. Start the server application.
2. Enter the listening port number on the Server GUI.
3. Monitor client interactions and channel activities in real-time.

### Client

1. Launch the client application.
2. Enter the server IP address and listening port.
3. Choose a unique username to connect.
4. Subscribe/unsubscribe to channels and send/receive messages.

## Client and Server Specifications

- **Server** handles multiple clients, ensures unique usernames, and reports all activities.
- **Client** allows setting server IP and port, unique username entry, and handles disconnections gracefully.
- **GUIs** reflect all necessary details for server-client interactions and channel statuses.
- **Connections** and message transfers use TCP sockets.
