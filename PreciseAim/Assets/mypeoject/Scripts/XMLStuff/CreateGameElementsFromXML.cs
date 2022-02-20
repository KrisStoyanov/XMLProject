using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Xml.Parser;
using UnityStandardAssets.Characters.FirstPerson;
using System;

public class CreateGameElementsFromXML : MonoBehaviour
{
    public static event Action<uint> ArrowsCountLoaded;
    public uint ArrowsCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        var gameElements = XmlParser.Deserialize(Constants.XmlFilePath);

        foreach(var currentFlyingObject in gameElements.Balloons)
        {
            GameObject prefab= (GameObject)Resources.Load("Prefabs/MovingObject", typeof(GameObject));
            Vector3 posisiton = new Vector3(currentFlyingObject.Transform.getPositionCoordinate("x"), currentFlyingObject.Transform.getPositionCoordinate("y"), currentFlyingObject.Transform.getPositionCoordinate("z"));
            GameObject newMoovingObject=Instantiate(prefab, posisiton, Quaternion.identity);
            newMoovingObject.GetComponent<MovingObjectScript>().Speed = currentFlyingObject.Speed;




            GameObject newCargoObject = null;
            GameObject cargoPrefab = (GameObject)Resources.Load("Prefabs/" + currentFlyingObject.Cargo, typeof(GameObject));
            newCargoObject = Instantiate(cargoPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            newMoovingObject.GetComponent<MovingObjectScript>().Cargo = newCargoObject.transform;
            newCargoObject.transform.SetParent(newMoovingObject.transform);
            newCargoObject.transform.localPosition = new Vector3(0, -3f, 0);

        }

        foreach (var currentTorch in gameElements.Torches)
        {
            GameObject prefab = (GameObject)Resources.Load("Prefabs/Torch", typeof(GameObject));
            Vector3 posisiton = new Vector3(currentTorch.Transform.getPositionCoordinate("x"), currentTorch.Transform.getPositionCoordinate("y"), currentTorch.Transform.getPositionCoordinate("z"));
            Quaternion quaternion = Quaternion.Euler(currentTorch.Transform.getRotationCoordinate("x"), currentTorch.Transform.getRotationCoordinate("y"), currentTorch.Transform.getRotationCoordinate("z"));
            Instantiate(prefab, posisiton, quaternion);
        }

        foreach (var currentArrow in gameElements.Arrows)
        {
            GameObject prefab = (GameObject)Resources.Load("Prefabs/ThrowingArrow", typeof(GameObject));
            Vector3 posisiton = new Vector3(currentArrow.Transform.getPositionCoordinate("x"), currentArrow.Transform.getPositionCoordinate("y"), currentArrow.Transform.getPositionCoordinate("z"));
            GameObject newArrow = Instantiate(prefab, posisiton, Quaternion.identity);
            newArrow.GetComponent<Rigidbody>().useGravity = true;
        }

        foreach (var currenHealthPotion in gameElements.HealthPotions)
        {
            GameObject prefab = (GameObject)Resources.Load("Prefabs/HealthPotion", typeof(GameObject));
            Vector3 posisiton = new Vector3(currenHealthPotion.Transform.getPositionCoordinate("x"), currenHealthPotion.Transform.getPositionCoordinate("y"), currenHealthPotion.Transform.getPositionCoordinate("z"));
            Instantiate(prefab, posisiton, Quaternion.identity);
        }
        ArrowsCount = gameElements.ArrowsCount;
        ArrowsCountLoaded?.Invoke(ArrowsCount);
    }

}
