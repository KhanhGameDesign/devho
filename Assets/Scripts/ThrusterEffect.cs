using UnityEngine;

public class ThrusterEffect : MonoBehaviour
{
    public ParticleSystem thrusterFlame;
    public Rigidbody2D spaceshipRb;

    void Update()
    {
        if (spaceshipRb != null && thrusterFlame != null)
        {
            var emission = thrusterFlame.emission;
            emission.rateOverTime = spaceshipRb.velocity.magnitude * 10; // Điều chỉnh theo tốc độ
        }
    }
}
