# Strategy Pattern
The _*Strategy Pattern*_ defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it. 

## Design Principles 
- Identify the aspects of your application that vary and separate them from what stays the same. 
- Program to an interface, not an implementation
- Favor composition over inheritance  

---

## Example: Duck Simulator
The example used in the book is a duck simulation software. There are three types of ducks Mallard, Redhead, and Rubber. All three classes extend a Duck base class that has the methods quack, swim, and display (display is an abstract method). 

The initial code can be found here: https://github.com/N3rdyM1k3/HFDP/tree/strategy-pattern-init/StrategyPattern

## The Problem
There is a request to update the system and add the ability for ducks to fly. The quick solution would be simply to add a new fly method to the Duck class, but then we end up with rubber ducks flying. This is clearly not correct. 

The problem code can be found here: https://github.com/N3rdyM1k3/HFDP/tree/strategy-pattern-break/StrategyPattern

Specifically, this commit shows the breaking change: https://github.com/N3rdyM1k3/HFDP/commit/b68cfe64a0f3f737c307740d4d6b2280b281341d#diff-708c89e5249161e491e3004f8075eb1c2713c58f78ee84ca37101815a606a7e4

## The Pattern
It might be tempting to just switch fly to be an abstract method and have each class implement fly/no fly logic but then you have duplicated logic about how to fly in each implementation. You could try and solve this with more complex inheritance trees, but that would quickly become unwieldy. 

To solve this with the strategy pattern, we define a new interface called IFlyBehavior that defines a single method Fly. This is the "family of algorithms" whose behaviors we want to separate from the "clients that use it" (in this case, each duck type is a client). 

The updated code can be found here: https://github.com/N3rdyM1k3/HFDP/tree/strategy-pattern-part-one/StrategyPattern