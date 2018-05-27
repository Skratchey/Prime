using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class Killing : MonoBehaviour
    {

        private PlatformerCharacter2D m_Character;

        // Use this for initialization
        void Start()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }

        // Update is called once per frame
        void Update()
        {
            //if (m_Character.GetComponent(""))
            //{
            //    m_Character.Destroy();
            //}
        }
    }
}
