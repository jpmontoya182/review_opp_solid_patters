# OOP 


### Encapsulation 

Help us hide the internal implementation details of the class by only exposing the necessary functionality to the outside world.

### Abstraction 

Reduce complexity by hiding unnecessary details.

### Inheritance

Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes).

Subclasses inherit properties and behaviours from their superclasses and can also add new features or override existing ones. Inheritance is often described in  terms of 'is-a' relationship.

### Polimorphism
Is  the ability of an object to take many forms.

***

### Coupling 
The degree of dependency between different classes

### Composition 
Composition involves creating complex objects by combining simpler objects or components. In composition, objects are assembled together to form larger structures, with each component object maintining its own state and behaviour. Composition is  often described in  terms of a "has-a" relationship.


***

## Composition vs Inheritance

### When to use Composition 
- When you need more flexibility in constructing objects by assembling smaller, resuable components 
- Where there is no clear 'is-a' relationship betwwen classes, and a 'has-a' relationship is more appropiate
- When you want to avoid limitations of inheritance, such as tigh coupling and the fragile base class problem

### When to use Inheritance:
- when there is a clear 'is-a' relationship between classes, and subclass objects can be treated as instances of their superclass
- When you want to promote code reuse by inheriting properties and behaviours from existing classes
- When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly through their common superclass interface

