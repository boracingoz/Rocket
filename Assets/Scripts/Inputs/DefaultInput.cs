using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Input
{
    public class DefaultInput
    {
       private DefaultInputActions _input;

       public bool IsForceUp { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultInputActions();

            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            
            _input.Enable();
        }
    }
}

