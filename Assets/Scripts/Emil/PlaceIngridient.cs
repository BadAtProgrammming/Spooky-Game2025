using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceIngredient : MonoBehaviour
{
    public string ingredientType;
    public Transform targetPosition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("IngredientZone"))
        {
            // Snap or place the ingredient in the correct position
            transform.position = targetPosition.position;
            // Optional: Disable drag functionality after placement
            GetComponent<DragItem>().enabled = false;
        }
    }
}

