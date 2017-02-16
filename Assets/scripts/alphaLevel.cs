using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphaLevel : scriptQuadrado {

	// Update is called once per frame
	void Update () {

            GetComponent<SpriteRenderer>().color = new Color(AlphaQuadadroZ,AlphaQuadadroZ,AlphaQuadadroZ);
            //AlphaQuadadroZ = 0;
    }
}
