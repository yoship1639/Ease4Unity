using System.Runtime.CompilerServices;
using UnityEngine;

public enum EaseType
{
    Linear,
    Spring,
    QuadIn,
    CubicIn,
    QuartIn,
    QuintIn,
    SinIn,
    ExpIn,
    CircleIn,
    BounceIn,
    BackIn,
    ElasticIn,
    QuadInOut,
    CubicInOut,
    QuartInOut,
    QuintInOut,
    SinInOut,
    ExpInOut,
    CircleInOut,
    BounceInOut,
    BackInOut,
    ElasticInOut,
    QuadOut,
    CubicOut,
    QuartOut,
    QuintOut,
    SinOut,
    ExpOut,
    CircleOut,
    BounceOut,
    BackOut,
    ElasticOut,
}

public static class Ease
{

    public static float Easing(this float t, EaseType type)
    {
        switch (type)
        {
            case EaseType.Linear:
                return t;
            case EaseType.Spring:
                return Spring(0f, 1f, t);
            case EaseType.QuadIn:
                return QuadIn(0f, 1f, t);
            case EaseType.QuadOut:
                return QuadOut(0f, 1f, t);
            case EaseType.QuadInOut:
                return QuadInOut(0f, 1f, t);
            case EaseType.CubicIn:
                return CubicIn(0f, 1f, t);
            case EaseType.CubicOut:
                return CubicOut(0f, 1f, t);
            case EaseType.CubicInOut:
                return CubicInOut(0f, 1f, t);
            case EaseType.QuartIn:
                return QuartIn(0f, 1f, t);
            case EaseType.QuartOut:
                return QuartOut(0f, 1f, t);
            case EaseType.QuartInOut:
                return QuartInOut(0f, 1f, t);
            case EaseType.QuintIn:
                return QuintIn(0f, 1f, t);
            case EaseType.QuintOut:
                return QuintOut(0f, 1f, t);
            case EaseType.QuintInOut:
                return QuintInOut(0f, 1f, t);
            case EaseType.SinIn:
                return SinIn(0f, 1f, t);
            case EaseType.SinOut:
                return SinOut(0f, 1f, t);
            case EaseType.SinInOut:
                return SinInOut(0f, 1f, t);
            case EaseType.ExpIn:
                return ExpIn(0f, 1f, t);
            case EaseType.ExpOut:
                return ExpOut(0f, 1f, t);
            case EaseType.ExpInOut:
                return ExpInOut(0f, 1f, t);
            case EaseType.CircleIn:
                return CircleIn(0f, 1f, t);
            case EaseType.CircleOut:
                return CircleOut(0f, 1f, t);
            case EaseType.CircleInOut:
                return CircleInOut(0f, 1f, t);
            case EaseType.BounceIn:
                return BounceIn(0f, 1f, t);
            case EaseType.BounceOut:
                return BounceOut(0f, 1f, t);
            case EaseType.BounceInOut:
                return BounceInOut(0f, 1f, t);
            case EaseType.BackIn:
                return BackIn(0f, 1f, t);
            case EaseType.BackOut:
                return BackOut(0f, 1f, t);
            case EaseType.BackInOut:
                return BackInOut(0f, 1f, t);
            case EaseType.ElasticIn:
                return ElasticIn(0f, 1f, t);
            case EaseType.ElasticOut:
                return ElasticOut(0f, 1f, t);
            case EaseType.ElasticInOut:
                return ElasticInOut(0f, 1f, t);
            default:
                return t;
        }
    }

    #region float
    public static float Spring(float s, float e, float t)
    {
        t = (Mathf.Sin(t * Mathf.PI * (0.2f + 2.5f * t * t * t)) * Mathf.Pow(1f - t, 2.2f) + t) * (1f + (1.2f * (1f - t)));
        return s + (e - s) * t;
    }

    public static float QuadIn(float s, float e, float v)
    {
        e -= s;
        return e * v * v + s;
    }

    public static float QuadOut(float s, float e, float t)
    {
        e -= s;
        return -e * t * (t - 2) + s;
    }

    public static float QuadInOut(float s, float e, float t)
    {
        t /= .5f;
        e -= s;
        if (t < 1) return e * 0.5f * t * t + s;
        t--;
        return -e * 0.5f * (t * (t - 2) - 1) + s;
    }

    public static float CubicIn(float s, float e, float t)
    {
        e -= s;
        return e * t * t * t + s;
    }

    public static float CubicOut(float s, float e, float t)
    {
        t--;
        e -= s;
        return e * (t * t * t + 1) + s;
    }

    public static float CubicInOut(float s, float e, float t)
    {
        t /= .5f;
        e -= s;
        if (t < 1) return e * 0.5f * t * t * t + s;
        t -= 2;
        return e * 0.5f * (t * t * t + 2) + s;
    }

    public static float QuartIn(float s, float e, float t)
    {
        e -= s;
        return e * t * t * t * t + s;
    }

    public static float QuartOut(float s, float e, float t)
    {
        t--;
        e -= s;
        return -e * (t * t * t * t - 1) + s;
    }

    public static float QuartInOut(float s, float e, float t)
    {
        t /= 0.5f;
        e -= s;
        if (t < 1) return e * 0.5f * t * t * t * t + s;
        t -= 2;
        return -e * 0.5f * (t * t * t * t - 2) + s;
    }

    public static float QuintIn(float s, float e, float t)
    {
        e -= s;
        return e * t * t * t * t * t + s;
    }

    public static float QuintOut(float s, float e, float t)
    {
        t--;
        e -= s;
        return e * (t * t * t * t * t + 1) + s;
    }

    public static float QuintInOut(float s, float e, float t)
    {
        t /= .5f;
        e -= s;
        if (t < 1) return e * 0.5f * t * t * t * t * t + s;
        t -= 2;
        return e * 0.5f * (t * t * t * t * t + 2) + s;
    }

    public static float SinIn(float s, float e, float t)
    {
        e -= s;
        return -e * Mathf.Cos(t * (Mathf.PI * 0.5f)) + e + s;
    }

    public static float SinOut(float s, float e, float t)
    {
        e -= s;
        return e * Mathf.Sin(t * (Mathf.PI * 0.5f)) + s;
    }

    public static float SinInOut(float s, float e, float t)
    {
        e -= s;
        return -e * 0.5f * (Mathf.Cos(Mathf.PI * t) - 1f) + s;
    }

    public static float ExpIn(float s, float e, float t)
    {
        e -= s;
        return e * Mathf.Pow(2f, 10f * (t - 1f)) + s;
    }

    public static float ExpOut(float s, float e, float t)
    {
        e -= s;
        return e * (-Mathf.Pow(2f, -10f * t) + 1f) + s;
    }

    public static float ExpInOut(float s, float e, float t)
    {
        t /= .5f;
        e -= s;
        if (t < 1f) return e * 0.5f * Mathf.Pow(2f, 10f * (t - 1f)) + s;
        t--;
        return e * 0.5f * (-Mathf.Pow(2f, -10f * t) + 2f) + s;
    }

    public static float CircleIn(float s, float e, float t)
    {
        e -= s;
        return -e * (Mathf.Sqrt(1f - t * t) - 1f) + s;
    }

    public static float CircleOut(float s, float e, float t)
    {
        t--;
        e -= s;
        return e * Mathf.Sqrt(1f - t * t) + s;
    }

    public static float CircleInOut(float s, float e, float t)
    {
        t /= 0.5f;
        e -= s;
        if (t < 1) return -e * 0.5f * (Mathf.Sqrt(1f - t * t) - 1f) + s;
        t -= 2f;
        return e * 0.5f * (Mathf.Sqrt(1f - t * t) + 1f) + s;
    }

    public static float BounceIn(float s, float e, float t)
    {
        e -= s;
        float d = 1f;
        return e - BounceOut(0, e, d - t) + s;
    }

    public static float BounceOut(float s, float e, float t)
    {
        t /= 1f;
        e -= s;
        if (t < (1f / 2.75f))
        {
            return e * (7.5625f * t * t) + s;
        }
        else if (t < (2f / 2.75f))
        {
            t -= (1.5f / 2.75f);
            return e * (7.5625f * t * t + 0.75f) + s;
        }
        else if (t < (2.5f / 2.75))
        {
            t -= (2.25f / 2.75f);
            return e * (7.5625f * t * t + 0.9375f) + s;
        }
        else
        {
            t -= (2.625f / 2.75f);
            return e * (7.5625f * t * t + 0.984375f) + s;
        }
    }

    public static float BounceInOut(float s, float e, float t)
    {
        e -= s;
        float d = 1f;
        if (t < d * 0.5f) return BounceIn(0, e, t * 2f) * 0.5f + s;
        else return BounceOut(0, e, t * 2f - d) * 0.5f + e * 0.5f + s;
    }

    private static float Back = 1.70158f;
    public static float BackIn(float s, float e, float t)
    {
        e -= s;
        return e * t * t * ((Back + 1f) * t - Back) + s;
    }

    public static float BackOut(float s, float e, float t)
    {
        e -= s;
        t = t - 1;
        return e * (t * t * ((Back + 1f) * t + Back) + 1f) + s;
    }

    public static float BackInOut(float s, float e, float t)
    {
        float ss = Back;
        e -= s;
        t /= 0.5f;
        if ((t) < 1f)
        {
            ss *= (1.525f);
            return e * 0.5f * (t * t * ((ss + 1f) * t - ss)) + s;
        }
        t -= 2f;
        ss *= (1.525f);
        return e * 0.5f * ((t) * t * ((ss + 1f) * t + ss) + 2f) + s;
    }

    public static float ElasticIn(float s, float e, float t)
    {
        e -= s;

        float d = 1f;
        float p = d * 0.3f;
        float ss;
        float a = 0;

        if (t == 0) return s;

        if ((t /= d) == 1f) return s + e;

        if (a == 0f || a < Mathf.Abs(e))
        {
            a = e;
            ss = p / 4f;
        }
        else
        {
            ss = p / (2f * Mathf.PI) * Mathf.Asin(e / a);
        }

        return -(a * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * d - ss) * (2f * Mathf.PI) / p)) + s;
    }

    public static float ElasticOut(float s, float e, float t)
    {
        e -= s;

        float d = 1f;
        float p = d * 0.3f;
        float ss;
        float a = 0;

        if (t == 0) return s;

        if ((t /= d) == 1f) return s + e;

        if (a == 0f || a < Mathf.Abs(e))
        {
            a = e;
            ss = p * 0.25f;
        }
        else
        {
            ss = p / (2f * Mathf.PI) * Mathf.Asin(e / a);
        }

        return (a * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * d - ss) * (2f * Mathf.PI) / p) + e + s);
    }

    public static float ElasticInOut(float s, float e, float t)
    {
        e -= s;

        float d = 1f;
        float p = d * 0.3f;
        float ss;
        float a = 0;

        if (t == 0) return s;

        if ((t /= d * 0.5f) == 2f) return s + e;

        if (a == 0f || a < Mathf.Abs(e))
        {
            a = e;
            ss = p / 4f;
        }
        else
        {
            ss = p / (2f * Mathf.PI) * Mathf.Asin(e / a);
        }

        if (t < 1f) return -0.5f * (a * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * d - ss) * (2f * Mathf.PI) / p)) + s;
        return a * Mathf.Pow(2f, -10f * (t -= 1f)) * Mathf.Sin((t * d - ss) * (2f * Mathf.PI) / p) * 0.5f + e + s;
    }
    #endregion

    #region Vector2
    public static Vector2 Spring(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, Spring(0f, 1f, t));
    }

    public static Vector2 QuadIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuadIn(0f, 1f, t));
    }

    public static Vector2 QuadOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuadOut(0f, 1f, t));
    }

    public static Vector2 QuadInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuadInOut(0f, 1f, t));
    }

    public static Vector2 CubicIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CubicIn(0f, 1f, t));
    }

    public static Vector2 CubicOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CubicOut(0f, 1f, t));
    }

    public static Vector2 CubicInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CubicInOut(0f, 1f, t));
    }

    public static Vector2 QuartIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuartIn(0f, 1f, t));
    }

    public static Vector2 QuartOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuartOut(0f, 1f, t));
    }

    public static Vector2 QuartInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuartInOut(0f, 1f, t));
    }

    public static Vector2 QuintIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuintIn(0f, 1f, t));
    }

    public static Vector2 QuintOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuintOut(0f, 1f, t));
    }

    public static Vector2 QuintInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, QuintInOut(0f, 1f, t));
    }

    public static Vector2 SinIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, SinIn(0f, 1f, t));
    }

    public static Vector2 SinOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, SinOut(0f, 1f, t));
    }

    public static Vector2 SinInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, SinInOut(0f, 1f, t));
    }

    public static Vector2 ExpIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, ExpIn(0f, 1f, t));
    }

    public static Vector2 ExpOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, ExpOut(0f, 1f, t));
    }

    public static Vector2 ExpInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, ExpInOut(0f, 1f, t));
    }

    public static Vector2 CircleIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CircleIn(0f, 1f, t));
    }

    public static Vector2 CircleOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CircleOut(0f, 1f, t));
    }

    public static Vector2 CircleInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, CircleInOut(0f, 1f, t));
    }

    public static Vector2 BounceIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BounceIn(0f, 1f, t));
    }

    public static Vector2 BounceOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BounceOut(0f, 1f, t));
    }

    public static Vector2 BounceInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BounceInOut(0f, 1f, t));
    }

    public static Vector2 BackIn(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BackIn(0f, 1f, t));
    }

    public static Vector2 BackOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BackOut(0f, 1f, t));
    }

    public static Vector2 BackInOut(Vector2 s, Vector2 e, float t)
    {
        return Vector2.LerpUnclamped(s, e, BackInOut(0f, 1f, t));
    }
    #endregion
}
