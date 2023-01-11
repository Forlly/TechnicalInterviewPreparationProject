using DG.Tweening;
using UnityEngine;

public class DOTweensTesting : MonoBehaviour
{
    [SerializeField] private float _speedMoving;
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _scale;

    void Start()
    {
        DOTween.Sequence()
            .SetEase(Ease.InOutQuart)
            .Append(transform.DOScale(_scale, 0.5f))
            .AppendInterval(0.5f)
            .Append(transform.DOScale(1.5f, 0.7f))
            .AppendCallback(EndAnimation)
            .AppendInterval(0.5f)
            .Append(transform.DOMove(new Vector3(2, 2, 0), _speedMoving))
            .Append(transform.DORotate(new Vector3(0, 180, 0), _speedRotate))
            .AppendInterval(0.5f)
            .Append(transform.DOMove(new Vector3(-2, -2, 0), _speedMoving))
            .Append(transform.DORotate(new Vector3(180, 0, 0), _speedRotate))
            .Append(transform.DOMove(new Vector3(0, 0, 0), _speedMoving))
            .SetLoops(-1);
    }


    private void EndAnimation()
    {
        Debug.Log("END");
    }
}
