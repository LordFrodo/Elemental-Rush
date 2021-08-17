using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets {
    public class Movement : MonoBehaviour
    {
        [SerializeField] int state;
        [SerializeField] ThirdPersonController controller;

        void Awake()
        {
            controller = GetComponent<ThirdPersonController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (state == 0)
            {
                controller.
            }

        }
    } 
}
