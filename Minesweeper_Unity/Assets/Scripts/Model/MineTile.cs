using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Minesweeper
{
    /// <summary>
    /// A class to hold the state of a Minesweeper tile
    /// </summary>
    public class MineTile : MonoBehaviour
    {
        public Text text;
        private Image image;
        private Image flag;
        public ButtonLongPress button;
        public Animator anim;

        public bool isRevealed;
        public bool isBomb;
        public bool isFlagged;
        public int x, y;
    }
}