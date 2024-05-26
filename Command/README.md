### Definition
The command pattern encapsulates a request as an object, allowing for parameterization of clients with different requests,
queuing of requests, and logging of requests.

### Usecases
Think of an IoT application where we have programmable lights and a remote control or mobile app that we want to control these
lights with. We have buttons for turning the light on and off, and for controlling the brightness.

Another possible usecase could be a scenario where we have a queue of requests that need to be executed in a specific order.
We can throttle requests based on our requirements if every request is encapsulated as a command object.

A real life application of the command pattern could be the way applications like PhotoShop allow the user to undo and redo their
changes. It is possible to create such a system by encapsulating each operation as a command object and storing them in a stack or queue.
