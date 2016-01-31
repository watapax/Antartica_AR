/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {



        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
		Terrain[] terrainComponents;
		Renderer[] rendererComponents;
		Collider[] colliderComponents;
		Canvas[] canvasComponents;


        #endregion // PRIVATE_MEMBER_VARIABLES





        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }



        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
		
			terrainComponents = GetComponentsInChildren<Terrain>(true);
			rendererComponents = GetComponentsInChildren<Renderer>(true);
			colliderComponents = GetComponentsInChildren<Collider>(true);
			canvasComponents = GetComponentsInChildren<Canvas>(true);
            // Enable rendering:
			for(int i = 0; i < rendererComponents.Length; i++)
			{
				rendererComponents[i].enabled = true;
			}

			for(int i = 0; i < terrainComponents.Length; i++)
			{
				terrainComponents[i].enabled = true;
			}

            // Enable colliders:
			for(int i = 0; i < colliderComponents.Length; i++)
			{
				colliderComponents[i].enabled = true;
			}
			for(int i = 0; i < canvasComponents.Length; i++)
			{
				canvasComponents[i].enabled = true;
			}



            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
        }


        private void OnTrackingLost()
        {
			terrainComponents = GetComponentsInChildren<Terrain>(true);
			rendererComponents = GetComponentsInChildren<Renderer>(true);
			colliderComponents = GetComponentsInChildren<Collider>(true);
			canvasComponents = GetComponentsInChildren<Canvas>(true);
            // Disable rendering:
			for(int i = 0; i < rendererComponents.Length; i++)
			{
				rendererComponents[i].enabled = false;
			}

			for(int i = 0; i < terrainComponents.Length; i++)
			{
				terrainComponents[i].enabled = false;
			}

            // Disable colliders:
			for(int i = 0; i < colliderComponents.Length; i++)
			{
				colliderComponents[i].enabled = false;
			}

			for(int i = 0; i < canvasComponents.Length; i++)
			{
				canvasComponents[i].enabled = false;
			}

	
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}

