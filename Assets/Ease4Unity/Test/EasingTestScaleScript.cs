using UnityEngine;

public class EasingTestScaleScript : MonoBehaviour
{
    public EaseType Type = EaseType.Linear;
    public Vector3 From = Vector3.one;
    public Vector3 To = Vector3.one * 0.5f;
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
            if (flag) transform.localScale = From;
            else transform.localScale = To;
        }

        if (wait <= 0.0f)
        {
            if (flag) transform.localScale = Vector3.LerpUnclamped(From, To, (time / Interval).Easing(Type));
            else transform.localScale = Vector3.LerpUnclamped(To, From, (time / Interval).Easing(Type));
        }
    }
}