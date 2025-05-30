using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlingshotHandler : MonoBehaviour
{
    [Header ("Line Renderers")]
    [SerializeField] private LineRenderer leftLineRenderer;
    [SerializeField] private LineRenderer rightLineRenderer;

    [Header ("Transform References")]
    [SerializeField] private Transform leftStartPosition;
    [SerializeField] private Transform rightStartPosition;
    [SerializeField] private Transform centerPosition;
    [SerializeField] private Transform idlePosition;

    [Header ("Slingshot Stats")]
    [SerializeField] private float maxDistance = 3.5f;
    [SerializeField] private float shotForce = 5f;
    [SerializeField] private float timeBetweenBirdRespawns = 2f;

    [Header ("Scripts")]
    [SerializeField] private SlingshotArea slingshotArea;

    [Header ("Bird")]
    [SerializeField] private AngryBird angryBirdPrefab;
    [SerializeField] private float angryBirdPositionOffset = 2f;

    private Vector2 slingshotLinePosition;

    private Vector2 direction;
    private Vector2 directionNormalized;

    private bool clickedWithinArea;
    private bool birdOnSlingshot;

    private AngryBird spawnAngryBird;

    private void Awake()
    {
        leftLineRenderer.enabled = false;
        rightLineRenderer.enabled = false;

        SpawnAngryBird();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && slingshotArea.isWithinSlingshotArea())
        {
            clickedWithinArea = true;
        }

        if (Mouse.current.leftButton.isPressed && clickedWithinArea && birdOnSlingshot)
        {
            drawSlingshot();
            PositionAndRotateAngryBird();
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame && birdOnSlingshot)
        {
            if (GameManager.instance.HasEnoughShots())
            {
                clickedWithinArea = false;
                birdOnSlingshot = false;

                spawnAngryBird.LaunchBird(direction, shotForce);
                GameManager.instance.UseShot();
                SetLines(centerPosition.position);

                if (GameManager.instance.HasEnoughShots())
                {
                    StartCoroutine(SpawningBirdAfterTime());
                }
            }
        }
    }

    private void drawSlingshot()
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        slingshotLinePosition = centerPosition.position + Vector3.ClampMagnitude(touchPosition - centerPosition.position, maxDistance);
        SetLines(slingshotLinePosition);

        direction = (Vector2)centerPosition.position - slingshotLinePosition;
        directionNormalized = direction.normalized;
    }

    private void SetLines(Vector2 position)
    {
        if(!(leftLineRenderer.enabled && rightLineRenderer.enabled))
        {
            leftLineRenderer.enabled = true;
            rightLineRenderer.enabled = true;
        }

        leftLineRenderer.SetPosition(0, position);
        leftLineRenderer.SetPosition(1, leftStartPosition.position);

        rightLineRenderer.SetPosition(0, position);
        rightLineRenderer.SetPosition(1, rightStartPosition.position);
    }

    private void SpawnAngryBird()
    {
        SetLines(idlePosition.position);

        Vector2 dir = (centerPosition.position - idlePosition.position).normalized;
        Vector2 spawnPosition = (Vector2)idlePosition.position + dir * angryBirdPositionOffset;

        spawnAngryBird = Instantiate(angryBirdPrefab, spawnPosition, Quaternion.identity);
        spawnAngryBird.transform.right = dir;

        birdOnSlingshot = true;
    }

    private void PositionAndRotateAngryBird()
    {
        spawnAngryBird.transform.position = slingshotLinePosition + directionNormalized * angryBirdPositionOffset;
        spawnAngryBird.transform.right = directionNormalized;
    }

    private IEnumerator SpawningBirdAfterTime()
    {
        yield return new WaitForSeconds(timeBetweenBirdRespawns);

        SpawnAngryBird();
    }
}
