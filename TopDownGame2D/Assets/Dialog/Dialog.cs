﻿using System;
using UnityEngine;

namespace Dialog
{
    [Serializable]
    public struct Dialog
    {
        [SerializeField] private string[] _story;
        [SerializeField] private Answer[] _answers;

        public string[] Story => _story;
        public Answer[] Answers => _answers;
    }
}