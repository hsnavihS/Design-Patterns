### Definition

The observer pattern is a behavioral design pattern that defines a one-to-many dependency between objects so that when one
object changes state, all its dependents are notified and updated automatically.

### Example
A list is a collection, and sorting is an algorithm that can be applied to a collection.
The strategy pattern allows the sorting algorithm to be changed without changing the list class.
Essentially, sorting now becomes a 'strategy' instead of an 'algorithm', which can be changed without changing the
implentation of the list class.

### Problem
Let's say we have a Duck interface, which is concretely implemented by MallardDuck and RubberDuck classes.
The Duck interface has a fly() method, which is implemented by both MallardDuck and RubberDuck classes.
However, the fly() method is not applicable to the RubberDuck class, as rubber ducks cannot fly.
We can simply override the fly() method and not do anything inside of it to signify a non-flying behaviour.
But this is a slippery slope as when we add more ducks to this system, we will have to override the fly() method
again and again, sometimes with the exact same piece of code that has been used elsewhere.
Similar to the fly() method, we can have other behaviours such as eating.

### Solution
Essentially, flying is a strategy that can be implemented using various algorithms. We want these strategies to be plug-and-play.
