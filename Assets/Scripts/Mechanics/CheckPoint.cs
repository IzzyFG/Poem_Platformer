using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// CheckPoint components mark a collider which will schedule a
    /// PlayerEnteredcheckpoint event when the player enters the trigger.
    /// </summary>
    public class CheckPoint : MonoBehaviour
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                model.spawnPoint = transform;
                // SpawnPoint.Update();
                // var ev = Schedule<PlayerEnteredCheckPoint>();
                // ev.checkpoint = this;
            }
        }
    }
}