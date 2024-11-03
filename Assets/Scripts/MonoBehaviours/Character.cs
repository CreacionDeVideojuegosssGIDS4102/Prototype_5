using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Clase genérica para todo tipo de personaje en el Juego.
*/

/*
Nombre: Mario Alberto Rangel Márquez
Descripción: Prototype 5
Fecha: 02/11/2024
*/
public abstract class Character : MonoBehaviour
{
    public HitPoints hitPoints; //Puntos actuales de jugador
    public float maxHitPoints; //Máximos puntos a obtener
}
