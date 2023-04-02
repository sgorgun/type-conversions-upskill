# Casting Unit Test Project

Intermediate level task for practicing casting operations.

Estimated time to complete the task - 1h.

The task requires .NET 6 SDK installed.


## Task Description

## Casting

The purpose of this task is to help you better understand the concept of 'Casting'.


### 1. Perform 'upcasting'

Implement the [CheckUpcasting](Casting/StudentLogic.cs#L7) method of the *StudentLogic* class:
* Write a code to perform upcasting of the 'Dog' class object into the 'Animal' class object  where 'Dog' is a child class and 'Animal' is a parent class.
* Also assign the Name property of *Animal* class to "scooby".
* This method returns the instance of *Animal* class.


### 2. Perform 'downcasting' 

Implement the [CheckDowncasting](Casting/StudentLogic.cs#L14) method of the *StudentLogic* class:
* Write a code to perform downcasting of  the 'Animal' class object into the 'Cat' class object where 'Cat' is a child class and 'Animal' is a parent class.
* This method returns the instance of *Cat* class.

### 3. Perform 'boxing'

Implement the [CheckBoxing](Casting/StudentLogic.cs#L21) method of the *StudentLogic* class:
* Write a code in such a way that the integer variable 'number' is boxed into object type.
* This method returns an object variable.

### 4. Perform 'unboxing' 

Implement the [CheckUnboxing](Casting/StudentLogic.cs#L28) method of the *StudentLogic* class:
* Write a code in such a way that the  provided object variable 'number' is unboxed  to  integer type.
* This method returns an integer variable.

### 5. Perform 'implicit casting'

Implement the [CheckImplicitCasting](Casting/StudentLogic.cs#L35) method of the *StudentLogic* class:
* Write a code in such a way that the parameter (a byte variable) passed will be converted to short, ushort, int, uint, long, ulong, float, double and decimal. 
* At the end, create a hashtable where key contains the type of the variable which has been obtained after typecasting and value contains the value of the variable.
* It returns a Hashtable.

### 6. Perform 'explicit casting' 

Implement the [CheckExplicitCasting](Casting/StudentLogic.cs#L43) method of the *StudentLogic* class:
* Write a code in such a way that the parameter (a decimal variable) passed is converted to short,ushort,int,uint,long,ulong and float type.
* At the end, create a hashtable where key contains the  type of the variable  which has been obtained after typecasting and value contains the value of the variable.
* It returns a Hashtable.

### 7. Perform 'user-defined casting'

Implement the [CheckUserdefinedcasting](Casting/StudentLogic.cs#L51) method of the *StudentLogic* class:
* Write a code in such a way that  the provided value is typecasted into double by overloading double (with the help of *UserDefinedCast* class) and changing its default behaviour
* At the end, add the object of the *UserDefinedCast*  class to the list<object> and then the typecasted value.
* It returns a list<object>.
