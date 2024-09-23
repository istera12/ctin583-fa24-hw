using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
    Unity's GetComponent<T> is a method used to retrieve a specific component attached 
    to a GameObject. It is a generic method because it uses a type parameter T to specify 
    which type of component you want to retrieve.
    
    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
    In generics, the letter T is conventionally used to represent a placeholder for a type. 
    It stands for "Type" and is widely used when defining generic classes, methods, or interfaces. 
    If there are multiple type parameters, the common naming convention is to use descriptive letters 
    like T1, T2, TKey, TValue, or more meaningful names that represent the role of each parameter. 
    This helps clarify the purpose of each type in the generic method or class. For example, 
    in a generic collection like a dictionary, <TKey, TValue> would represent the key and value types, 
    respectively, improving readability and understanding of the code.


    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
    A generic variable acts as a placeholder for a specific data type, allowing a method or class to operate on 
    any type without hardcoding it. In a generic method, this variable is used as both the argument type and return 
    type to ensure the method can accept and return values of the same type, which is determined when the method is called. 
    This design makes the method flexible and reusable for any type, maintaining type safety and avoiding unnecessary casting.

    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
    In a game, generics are useful when you need to create reusable systems, like an inventory system that can store different
    item types (weapons, potions, etc.) without duplicating code. For example, you could create a generic ItemStack<T> class
    that handles adding, removing, or managing quantities of any item type (T). Using type variables ensures that your code
    works for any item type while maintaining type safety, allowing you to store and manage items consistently, whether 
    they are Potion, Weapon, or Armor. This keeps your code flexible and prevents redundancy.

    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
    In C#, generic arrays (e.g., T[]) offer better performance than non-generic arrays (e.g., object[]) because 
    they avoid boxing and unboxing when storing value types like int or float. Generic arrays directly store the 
    specified type, leading to faster access and reduced memory overhead. In contrast, non-generic arrays store 
    elements as object, causing value types to be boxed, which introduces additional memory allocation and processing 
    overhead, reducing performance.


    * What does it mean to instantiate? 
    To instantiate means to create an instance of an object from a class or blueprint. In programming, this refers to 
    allocating memory and setting up an object based on its class definition, making it ready for use. For example, in C#, 
    you instantiate a class like this: MyClass obj = new MyClass();. Here, obj is a new instance of MyClass.
    
    
    */
public class BarbieWorld<T>
{
    T item; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
    Answer - It is trying to set Barbie’s career to a new value. The generic T allows the function to accept any type for newCareer, 
    making it flexible to handle different types of career information.

    How are we using the T variable in this case?
    Answer - GetComponent<T> is a Unity method used to retrieve a component of type T from a GameObject. 
    The T in GetComponent<T> is a placeholder for any type of component attached to the GameObject.

    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */


    public string currentCareer;

    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }

    
}