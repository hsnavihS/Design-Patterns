### Definition
The decorator patterns attaches additional responsibilities to an object dynamically.
Decorators provide a flexible alternative to subclassing for extending functionality.

### Problem
A coffee shop wants to offer a variety of coffee drinks. Each drink can have different ingredients and prices.
The shop wants to be able to add new ingredients and drinks in the best way possible.

### Bad approach #1
Create a class for each possible combination of drink and condiment(s).
Eg: `Espresso`, `EspressoWithMilk`, `EspressoWithMilkAndSugar`, `EspressoWithMilkAndSugarAndChocolate`, etc.
This creates a class explosion, which means that we have tons of classes to maintain.

### Bad approach #2
All condiments can be represented as booleans, for example: hasMilk(), hasSugar(), hasChocolate() etc.
- Conditionals breed, and returning booleans provokes the use of conditionals.
- Adding new condiments would require editing the class.
- If a drink like tea was added, and a condiment called chocolate existed, the code would still work even
though it wouldn't make any sense for it to have chocolate in it. This is happening because of the usage of inheritance.
- The calculation of cost would be a mess because of all these conditionals and all ingredients having different costs.

### Solution
Creating a separate component (decorator) which is a beverage and has a beverage (but actually is a condiment).
Each condiment is a decorator that wraps a beverage (as well as another condiment).
