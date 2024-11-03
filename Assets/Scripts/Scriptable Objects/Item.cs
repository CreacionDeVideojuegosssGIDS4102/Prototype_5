using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
Nombre: Mario Alberto Rangel Márquez
Descripción: Prototype 5
Fecha: 02/11/2024
*/

[CreateAssetMenu(menuName = "Item")] //Opción más en el menú
public class Item : ScriptableObject
{
    public string objectName; //Nombre del personaje
    public Sprite sprite; //Referencia a un Item Sprite
    public int quantity; //Cantidad de un Item específico
    public bool stackable; //Múltiples copias
    public ItemType itemType; //Tipo de un elemento
    public enum ItemType //Identifica el tipo objeto consumible
    {
        COIN,
        HEALTH
    }
}
