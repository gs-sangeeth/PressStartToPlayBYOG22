using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration = 1f;

    private float shakeStrength = 1f;

    public static CameraShake instance;

    private void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    public IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength * shakeStrength;
            yield return null;
        }

        transform.position = startPosition;
        shakeStrength = 1f;
        duration = 1f;
    }

    public void Shake(float shakeStrength = 1,float duration = 1)
    {
        this.shakeStrength = shakeStrength;
        this.duration = duration;
        start = true;
    }

}
