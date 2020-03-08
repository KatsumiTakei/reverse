﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScene : SceneBase
    , IInputResponder
{
    private void OnEnable()
    {
        EventManager.OnMultipleInput += OnMultipleInput;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ProgressManager.Instance.GetReleaseCnt());

    }

    private void OnDisable()
    {
        EventManager.OnMultipleInput -= OnMultipleInput;
    }


    public void OnMultipleInput(eInputType inputType, sbyte index, eHIDType hIDType)
    {
        if (inputType == eInputType.SpaceKeyDown)
        {
            ProgressManager.Instance.MoveScene(eSceneState.Title);
        }
    }

    public override void Open()
    {
        gameObject.SetActive(true);
    }

    public override void Close()
    {
        gameObject.SetActive(false);
    }
}