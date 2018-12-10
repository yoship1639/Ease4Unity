using UnityEngine;

public class TestEaseFactoryScript : MonoBehaviour
{
    void Start()
    {
        for (var i = 0; i < 32; i++)
        {
            var go = Resources.Load<GameObject>("Sphere");
            Instantiate(go);
            var s = go.GetComponent<EasingTestMoveScript>();
            s.From = new Vector3(-16, 0.0f, 16 - i);
            s.To = new Vector3(16, 0.0f, 16 - i);
            s.Type = (EaseType)i;
        }
    }
}