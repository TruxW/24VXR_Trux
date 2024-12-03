using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeBook : MonoBehaviour
{
    // lists used to store ingredients, recipes and selected ingredients
    public List<Ingredients> ingredients = new List<Ingredients>();
    //public List<Recipe> recipe = new List<Recipe>();
    //public List<int> usedIngredients = new List<int>();

   // array for spawn points to spawn ingredients needed for the recipe
   // public Transform[] recipeSpawn;

    // int to store the ID of the chosen recipe
    //public int chosenRecipeID;


    // since this script is in the scene at runtime, we can use a serizlied field to 
    // reference the panLogic script
    //[SerializeField]
    //private PanLogic panLogic;


    // float to track increments earnings
    //public float earnings;

    

    // Start is called before the first frame update
    void Start()
    {
        ingredients.Add(new Ingredients("Green", 0, Resources.Load("Ingredients/GreenCube") as GameObject, 4));
        Debug.Log("Green");
        ingredients.Add(new Ingredients("Blue", 1, Resources.Load("Ingredients/BlueCube") as GameObject, 7));
        Debug.Log("Blue");
        ingredients.Add(new Ingredients("Red", 2, Resources.Load("Ingredients/RedCube") as GameObject, 11));
        Debug.Log("Red");
        ingredients.Add(new Ingredients("White", 3, Resources.Load("Ingerdients/WhiteCube") as GameObject, 4));
        Debug.Log("White");
        ingredients.Add(new Ingredients("Yellow", 4, Resources.Load("Ingerdients/YellowCube") as GameObject, 11));
        Debug.Log("Yellow");
        

        //2.1.5.10, 3.2.3.7., 4.3.2.8.
        //recipe.Add(new Recipe("Recipe 1", 0, 3, 5, Random.IngredientLists(), 20));
       // recipe.Add(new Recipe("Recipe 2", 1, 5, 10, Random.IngredientLists(), 40);
       // recipe.Add(new Recipe("Recipe 3", 2, 3, 7, Random.IngrientLists(), 30));
      //  recipe.Add(new Recipe("Recipe 4", 3, 2, 8, Random.IngrientLists(), 10));
       

       SpawnIngredients();

    }

    public void SpawnIngredients()
      
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            Debug.Log(ingredients[i]);

            GameObject tempObj = Instantiate(ingredients[i].prefab);

            tempObj.name = i.ToString();

            Vector3 tempV3 = tempObj.transform.position;
            tempObj.transform.position = new Vector3(tempV3.x + (i * 1), tempV3.y, tempV3.z);


        }

       
    }
   
}
