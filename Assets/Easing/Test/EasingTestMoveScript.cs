using UnityEngine;

public class EasingTestMoveScript : MonoBehaviour
{
    public EaseType Type = EaseType.Linear;
    public Vector3 From;
    public Vector3 To;
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
            if (flag) transform.position = From;
            else transform.position = To;
        }

        if (wait <= 0.0f)
        {
            if (flag) transform.position = Vector3.LerpUnclamped(From, To, (time / Interval).Easing(Type));
            else transform.position = Vector3.LerpUnclamped(To, From, (time / Interval).Easing(Type));
        }
    }
}