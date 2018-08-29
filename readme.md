# Diagnostic Server Client

### What is this
This is a windows application designed to talk to the Phoenix Diagnostic Server executable built for Athena on the RoboRIO.

It contains the source code for the windows application along with the binary to be placed in the RoboRIO file system.

### How to use it
1. Copy Diagnostic_Server_Binary/Phoenix_Diagnostic_server to the RoboRIO's lvuser/home directory
2. SSH into the RoboRIO
3. cd //home/lvuser
4. ./Phoenix_Diagnostic_server
5. Open Windows application
6. Under IPAddrSelector, type in the address of the RoboRIO. 172.22.11.2 will be filled out in the dropdown box if you are currently connected over USB.
7. Hit connect and you're good to go.

### How it works
The server binary runs an http server on whatever is hosting it. Any URI made to the server will be handled, and may prompt the server to do something.

There are two main URI's that are sent to the server from the client, a POST and a GET. POST's are used when uploading a firmware file to the server, and when handling anything with device configs. GET's are used for everything else.

Most of the functions the server is able to do are handled with GET requests, specifying the device, the id, and the action in the url of request in the format of /?device=*srx*&id=*0*&action=*blink* (*Italicized* text being parameters).

Configuration parameters are mostly handled using json files. Every device will have a json file that goes with it, detailing what groups of configs it contains. For example, a TalonSRX will contain a group of hardware limit switches, software limit switches, current limits, etc. A VictorSPX will only contain software limit switches.

### Key notes
- The server is being ran on port 8181, this means you **must** append :8181 to the address you specify if you want to create your own application. The client handles this for you.
- This is not finished yet. It will look nicer when it is finished.
- Most of the config parameters are not available currently.
  