using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class TagController : MonoBehaviour
    {
        [Tooltip("Key to turn tag on")]
        public KeyCode SpawnKey = KeyCode.Return;

        [Tooltip("Key to turn tag off")]
        public KeyCode DespawnKey = KeyCode.Backspace;

        [Tooltip("Tags to control")]
        public List<GameObject> Targets;

        public void Update()
        {
            if (Input.GetKeyUp(DespawnKey))
            {
                Targets.ForEach(target => target.SetActive(false));
            }
            if (Input.GetKeyUp(SpawnKey))
            {
                Targets.ForEach(target => target.SetActive(true));
            }
        }
    }
}