﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaeLaChess.Assets.ChessPieces
{
    /// <summary>
    /// Interaction logic for WhitePawn.xaml
    /// </summary>
    public partial class WhitePawn : UserControl
    {
        public WhitePawn()
        {
            InitializeComponent();
        }
        private string _color = "white";
        private bool _firstmove = new bool();

        public bool HasTakenFirstMove
        {
            get { return this._firstmove; }
            set {this._firstmove = value;}
        }
        public string PieceColor
        {
            get { return this._color; }
        }
    }
}