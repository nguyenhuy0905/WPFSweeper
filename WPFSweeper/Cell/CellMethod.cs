﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFSweeper
{
    //constructor and methods of the Cell class
    public partial class Cell
    {
        /// <summary>
        /// Constructor of the Cell class. If loading a new game, only x and y should be filled
        /// </summary>
        /// <param name="x">x-position of the cell</param>
        /// <param name="y">y-position of the cell</param>
        /// <param name="edge">The length of an edge of the cell</param>
        /// <param name="type">The cell type. By default, this is NormalUnflagged</param>
        public Cell(int x, int y, int edge, CellType type = CellType.NormalUnflagged)
        {
            //assigning instance values and the Click event
            this.X = x;
            this.Y = y;
            this.Index = 0;
            SetProperties(type);
            this.IsChecked = false;
            this.Width = this.Height = edge;
            this.Click += LeftClick;
            this.MouseRightButtonDown += RightClick;
        }

        /// <summary>
        /// Triggers when left mouse button is clicked.
        /// </summary>
        /// <remarks>
        /// There are a few cases for the click:
        /// <list type="bullet">
        ///     <item>
        ///         <term>If the Cell has mine</term>
        ///         <description>You've got skillissue. Throw a loss message and escape the game</description>
        ///     </item>
        ///     <item>
        ///         <term>If the cell has index 0</term>
        ///         <description>Open its neighboring cells also</description>
        ///     </item>
        ///     <item>
        ///         <term>If the cell is flagged</term>
        ///         <description>Do nothing</description>
        ///     </item>
        ///     <item>
        ///         <term>If the cell has index from 1 to 7</term>
        ///         <description>Open itself only</description>
        ///     </item>
        /// </list>
        /// </remarks>
        private void LeftClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("left");
        }

        /// <summary>
        /// Triggers when right mouse button is clicked.
        /// </summary>
        /// <remarks>
        /// Simply, flips the IsFlagged property. If it's true then it's now false, if it's false then it's true.
        /// Maybe I will add a question-mark sign later
        /// </remarks>
        private void RightClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("right");
        }

        /// <summary>
        /// Change cell properties and appearance (excluding the cell's dimension)
        /// </summary>
        /// <param name="type">the cell type</param>
        private void SetProperties(CellType type)
        {
            //Normal cell
            this.IsFlagged = false;
            this.HasMine = false;
            //other types
            switch(type)
            {
                case CellType.Clicked:
                    this.IsClicked = true;
                    this.Background = Brushes.Aqua;
                    break;
                case CellType.MineUnflagged:
                    this.HasMine = true;
                    this.Background = Brushes.Aquamarine;
                    break;
                case CellType.MineFlagged:
                    this.IsFlagged = true;
                    goto case CellType.MineUnflagged;
                case CellType.NormalFlagged:
                    this.IsFlagged = true;
                    this.Background= Brushes.Aquamarine;
                    break;
                default:
                    break;
            }
        }

        
    }
}
