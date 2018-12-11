using UnityEngine;

public class EasingTestRotScript : MonoBehaviour
{
    public EaseType Type = EaseType.Linear;
    public Vector3 From = Vector3.zero;
    public Vector3 To = new Vector3(0.0f, 90.0f, 0.0f);
    public float Interval = 2.0f;

    bool flag;
    float time;
    float wait;

    void Update()
    {
        if (wait <= 0.0) time += Time.deltaTime;
        else wait -= Time.deltaTime;

        if (time > Interval)
        {
            wait = 1.0f;
            time = 0.0f;
            flag = !flag;
            transform.rotation = Quaternion.Euler(From);
        }

        if (wait <= 0.0f)
        {
            transform.rotation = Quaternion.SlerpUnclamped(Quaternion.Euler(From), Quaternion.Euler(To), (time / Interval).Easing(Type));
        }
    }
}