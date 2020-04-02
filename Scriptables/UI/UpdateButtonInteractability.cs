﻿using UnityEngine.UI;

namespace SO.UI
{
    public class UpdateButtonInteractability : UIPropertyUpdater
    {
        public BoolVariable targetBool;
        public Button targetButton;

        public override void Raise()
        {
            targetButton.interactable = targetBool.value;
        }
    }
}