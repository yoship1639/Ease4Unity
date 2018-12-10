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

    #region Vector3
    public static Vector3 Spring(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, Spring(0f, 1f, t));
    }

    public static Vector3 QuadIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuadIn(0f, 1f, t));
    }

    public static Vector3 QuadOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuadOut(0f, 1f, t));
    }

    public static Vector3 QuadInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuadInOut(0f, 1f, t));
    }

    public static Vector3 CubicIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CubicIn(0f, 1f, t));
    }

    public static Vector3 CubicOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CubicOut(0f, 1f, t));
    }

    public static Vector3 CubicInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CubicInOut(0f, 1f, t));
    }

    public static Vector3 QuartIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuartIn(0f, 1f, t));
    }

    public static Vector3 QuartOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuartOut(0f, 1f, t));
    }

    public static Vector3 QuartInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuartInOut(0f, 1f, t));
    }

    public static Vector3 QuintIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuintIn(0f, 1f, t));
    }

    public static Vector3 QuintOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuintOut(0f, 1f, t));
    }

    public static Vector3 QuintInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, QuintInOut(0f, 1f, t));
    }

    public static Vector3 SinIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, SinIn(0f, 1f, t));
    }

    public static Vector3 SinOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, SinOut(0f, 1f, t));
    }

    public static Vector3 SinInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, SinInOut(0f, 1f, t));
    }

    public static Vector3 ExpIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, ExpIn(0f, 1f, t));
    }

    public static Vector3 ExpOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, ExpOut(0f, 1f, t));
    }

    public static Vector3 ExpInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, ExpInOut(0f, 1f, t));
    }

    public static Vector3 CircleIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CircleIn(0f, 1f, t));
    }

    public static Vector3 CircleOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CircleOut(0f, 1f, t));
    }

    public static Vector3 CircleInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, CircleInOut(0f, 1f, t));
    }

    public static Vector3 BounceIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BounceIn(0f, 1f, t));
    }

    public static Vector3 BounceOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BounceOut(0f, 1f, t));
    }

    public static Vector3 BounceInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BounceInOut(0f, 1f, t));
    }

    public static Vector3 BackIn(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BackIn(0f, 1f, t));
    }

    public static Vector3 BackOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BackOut(0f, 1f, t));
    }

    public static Vector3 BackInOut(Vector3 s, Vector3 e, float t)
    {
        return Vector3.LerpUnclamped(s, e, BackInOut(0f, 1f, t));
    }
    #endregion

    #region Vector4
    public static Vector4 Spring(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, Spring(0f, 1f, t));
    }

    public static Vector4 QuadIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuadIn(0f, 1f, t));
    }

    public static Vector4 QuadOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuadOut(0f, 1f, t));
    }

    public static Vector4 QuadInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuadInOut(0f, 1f, t));
    }

    public static Vector4 CubicIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CubicIn(0f, 1f, t));
    }

    public static Vector4 CubicOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CubicOut(0f, 1f, t));
    }

    public static Vector4 CubicInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CubicInOut(0f, 1f, t));
    }

    public static Vector4 QuartIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuartIn(0f, 1f, t));
    }

    public static Vector4 QuartOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuartOut(0f, 1f, t));
    }

    public static Vector4 QuartInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuartInOut(0f, 1f, t));
    }

    public static Vector4 QuintIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuintIn(0f, 1f, t));
    }

    public static Vector4 QuintOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuintOut(0f, 1f, t));
    }

    public static Vector4 QuintInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, QuintInOut(0f, 1f, t));
    }

    public static Vector4 SinIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, SinIn(0f, 1f, t));
    }

    public static Vector4 SinOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, SinOut(0f, 1f, t));
    }

    public static Vector4 SinInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, SinInOut(0f, 1f, t));
    }

    public static Vector4 ExpIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, ExpIn(0f, 1f, t));
    }

    public static Vector4 ExpOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, ExpOut(0f, 1f, t));
    }

    public static Vector4 ExpInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, ExpInOut(0f, 1f, t));
    }

    public static Vector4 CircleIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CircleIn(0f, 1f, t));
    }

    public static Vector4 CircleOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CircleOut(0f, 1f, t));
    }

    public static Vector4 CircleInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, CircleInOut(0f, 1f, t));
    }

    public static Vector4 BounceIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BounceIn(0f, 1f, t));
    }

    public static Vector4 BounceOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BounceOut(0f, 1f, t));
    }

    public static Vector4 BounceInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BounceInOut(0f, 1f, t));
    }

    public static Vector4 BackIn(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BackIn(0f, 1f, t));
    }

    public static Vector4 BackOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BackOut(0f, 1f, t));
    }

    public static Vector4 BackInOut(Vector4 s, Vector4 e, float t)
    {
        return Vector4.LerpUnclamped(s, e, BackInOut(0f, 1f, t));
    }
    #endregion

    #region Quaternion
    public static Quaternion Spring(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, Spring(0f, 1f, t));
    }

    public static Quaternion QuadIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuadIn(0f, 1f, t));
    }

    public static Quaternion QuadOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuadOut(0f, 1f, t));
    }

    public static Quaternion QuadInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuadInOut(0f, 1f, t));
    }

    public static Quaternion CubicIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CubicIn(0f, 1f, t));
    }

    public static Quaternion CubicOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CubicOut(0f, 1f, t));
    }

    public static Quaternion CubicInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CubicInOut(0f, 1f, t));
    }

    public static Quaternion QuartIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuartIn(0f, 1f, t));
    }

    public static Quaternion QuartOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuartOut(0f, 1f, t));
    }

    public static Quaternion QuartInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuartInOut(0f, 1f, t));
    }

    public static Quaternion QuintIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuintIn(0f, 1f, t));
    }

    public static Quaternion QuintOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuintOut(0f, 1f, t));
    }

    public static Quaternion QuintInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, QuintInOut(0f, 1f, t));
    }

    public static Quaternion SinIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, SinIn(0f, 1f, t));
    }

    public static Quaternion SinOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, SinOut(0f, 1f, t));
    }

    public static Quaternion SinInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, SinInOut(0f, 1f, t));
    }

    public static Quaternion ExpIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, ExpIn(0f, 1f, t));
    }

    public static Quaternion ExpOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, ExpOut(0f, 1f, t));
    }

    public static Quaternion ExpInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, ExpInOut(0f, 1f, t));
    }

    public static Quaternion CircleIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CircleIn(0f, 1f, t));
    }

    public static Quaternion CircleOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CircleOut(0f, 1f, t));
    }

    public static Quaternion CircleInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, CircleInOut(0f, 1f, t));
    }

    public static Quaternion BounceIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BounceIn(0f, 1f, t));
    }

    public static Quaternion BounceOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BounceOut(0f, 1f, t));
    }

    public static Quaternion BounceInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BounceInOut(0f, 1f, t));
    }

    public static Quaternion BackIn(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BackIn(0f, 1f, t));
    }

    public static Quaternion BackOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BackOut(0f, 1f, t));
    }

    public static Quaternion BackInOut(Quaternion s, Quaternion e, float t)
    {
        return Quaternion.SlerpUnclamped(s, e, BackInOut(0f, 1f, t));
    }
    #endregion
}
