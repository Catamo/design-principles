# Single Responsability Principle

The S in SOLID. It stands for Single Responsability Principle. SRP says that you only need one reason to change per class. The code may change at different times, but it will always change because of the same reason.

## Pros / Cons

* Pros:
	* When you want to make a change, you should know exactly where to go
	* Easier to read the code
	* Changes are made throughout the whole application when changing the source 
	* Breaks the application appart and force you to think what the class do
* Cons:
	* Creates a lot of Classes (which is not that bad, as it lets you know which class is responsible of a feature)
	* If done incorrectly, it can lead to a bloated project

In summary, try to find a balance. And a rule of thumb is, if your class scrolls, it is probably too big. Think "Do I have to change this class for two different reasons", if the answer is yes, split it apart.

