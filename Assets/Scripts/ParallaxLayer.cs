using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax
{
    public static float speed = 5f;

}

public class ParallaxLayer : MonoBehaviour
{
    //initialize background
    public Transform[] tiles;

    //initialize repeat position variables after going a certain distance
    [SerializeField] float left = -1000f;
    [SerializeField] Vector3 right = new Vector3(2171.52f, 194.51f, 0f);

    //initialize the rate at which the background is moving
    [SerializeField] float rate = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the background to the left
        for(int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.speed * rate;

            //postion to repeat if goes a certain distance
            if(tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
