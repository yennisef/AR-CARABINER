using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia {



public class DataTarget : MonoBehaviour
{
        public Transform Title;
        public Transform TextDescription;
        public Transform PanelDescription;
        public GameObject Info;

      
        // Use this for initialization
        void Start()
        {
		
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
			
//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                Title.GetComponent<Text>().text = name;               
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);


            }
        }

}
}