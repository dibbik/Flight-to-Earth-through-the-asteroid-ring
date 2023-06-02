using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.Earth
{
    public class EarthRootScript : MonoBehaviour
    {
        private void Update()
        {
            transform.Rotate(0.0f, 0.01f, 0.0f);

        }
    }
}
