using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : MonoBehaviour
{
     // Method to describe furniture in Barbie's house
    public void AddFurniture(string furnitureItem)
    {
        Console.WriteLine($"Added furniture: {furnitureItem}");
    }

    // Method to describe pets in Barbie's house
    public void AddPet(string petName)
    {
        Console.WriteLine($"Added pet: {petName}");
    }

    // Method to list household items in Barbie's house
    public void ListHouseholdItems(string itemName)
    {
        Console.WriteLine($"Household item: {itemName}");
    }
}