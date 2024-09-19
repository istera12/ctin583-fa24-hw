using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank : MonoBehaviour
{

    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */

    void Start()
    {
        int[] T = BarbieWallet(500, 600);
        Debug.Log(T.Length + " " + T[0] + " " + T[1]);

        GetMoney(500, 600);

        private T[] BarbieBank<T>(int numOfPennies, T cashAmount, int numOfCreditCards)
        {
        // Create an array with the length based on the total number of items
        T[] bankArray = new T[numOfPennies + numOfCreditCards];
        
        // Fill the array with the provided cashAmount value (for demonstration)
        for (int i = 0; i < bankArray.Length; i++)
        {
            bankArray[i] = cashAmount;
        }
        
        return bankArray;



        barbieCareers = GetComponent<BarbieCareers>();
        
        // Set Barbie's career to "Photographer"
        if (barbieCareers != null) {
            barbieCareers.SetCareer("Photographer");
        }

    }

    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
        Answer - The protected access modifier in C# allows members of a class to be accessible within the class itself 
        and by derived (subclass) classes. It enables derived classes to use and modify these members, facilitating 
        inheritance and code reuse, while keeping them hidden from other classes not in the inheritance hierarchy.

        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
        MonoBehaviour is a base class in Unity from which all script components derive. Unity C# scripts inherit from 
        MonoBehaviour to gain access to Unity-specific functionality and lifecycle methods, such as Start(), Update(), 
        and Awake(). These methods allow scripts to respond to game events, initialize objects, and perform regular updates. 
        For example, Start() is called before the first frame update, and Update() is called once per frame.

        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
        Multiple inheritance is a feature where a class can inherit from more than one base class. In C#, multiple 
        inheritance is not supported for classes to avoid complexities and ambiguities in the inheritance hierarchy. 
        nstead, C# uses interfaces to achieve similar functionality, allowing a class to implement multiple interfaces 
        and thus inherit behaviors from multiple sources.

        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
        protected virtual void is a method declaration in C# where protected means the method is accessible within its class 
        and derived classes, and virtual allows derived classes to override it. The virtual keyword indicates that the method 
        can be overridden in subclasses to provide a specific implementation, enabling polymorphism and customizing behavior 
        in derived classes.


        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
        When a constructor in a parent class is called, it initializes the base class's state and ensures that the base class 
        is properly set up before the derived class adds or modifies its own state. In C#, you control which base class 
        constructor is called by specifying it explicitly in the derived class's constructor using the base keyword.

     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}