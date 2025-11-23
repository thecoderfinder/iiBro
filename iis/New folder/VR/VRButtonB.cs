using UnityEngine;
using UnityEngine.XR;
namespace iiStupid.VR { public class VRButtonB : MonoBehaviour {
    // VRButtonB - VR Input for ii's Stupid Menu (e.g., thumbsticks, index triggers
    // https://github.com/thecoderfinder/iiBro
    void Update() {
        if (InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 axis))
            Debug.Log("[VR] VRButtonB: " + axis);
    }
} }
