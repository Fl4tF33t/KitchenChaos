using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounterVisual : MonoBehaviour
{
    [SerializeField]
    private CuttingCounter containerCounter;
    private Animator animator;

    private const string CUT = "Cut";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        containerCounter = GetComponentInParent<CuttingCounter>();
    }

    private void Start()
    {
        containerCounter.OnCut += ContainerCounter_OnCut;
    }

    private void ContainerCounter_OnCut(object sender, System.EventArgs e)
    {
        animator.SetTrigger(CUT);
    }
}
