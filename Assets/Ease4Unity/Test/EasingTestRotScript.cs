using UnityEngine;

public class EasingTestRotScript : MonoBehaviour
{
    public EaseType Type = EaseType.Linear;
    public Quaternion From = Quaternion.identity;
    public Quaternion To = Quaternion.Euler(0.0f, 90.0f, 0.0f);
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
            if (flag) transform.rotation = From;
            else transform.rotation = To;
        }

        if (wait <= 0.0f)
        {
            if (flag) transform.rotation = Quaternion.SlerpUnclamped(From, To, (time / Interval).Easing(Type));
            else transform.rotation = Quaternion.SlerpUnclamped(To, From, (time / Interval).Easing(Type));
        }
    }
}