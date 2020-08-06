using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowControll
{
    public partial class Main : Form
    {
        Child child = new Child();
        public Main()
        {
            InitializeComponent();

            initializeWindowSizeController();
            initializeColorController();
            initializeChildWindow();
        }

        
        private void initializeColorController()
        {
            //子ウィンドウ背景色制御の初期化
            trackColorR.Value = 0;
            labelColorRValue.Text = trackColorR.Value.ToString();
            trackColorG.Value = 0;
            labelColorGValue.Text = trackColorG.Value.ToString();
            trackColorB.Value = 0;
            labelColorBValue.Text = trackColorB.Value.ToString();
        }

        private void initializeWindowSizeController()
        {
            //子ウィンドウ座標制御の初期化
            trackMoveDistance.Value = 1;
            labelMoveDistanceValue.Text = trackMoveDistance.Value.ToString();
            trackWidth.Value = 1;
            trackWidth.Maximum = Screen.PrimaryScreen.Bounds.Width;
            labelWidthValue.Text = trackWidth.Value.ToString();
            trackHeight.Value = 1;
            trackHeight.Maximum = Screen.PrimaryScreen.Bounds.Height;
            labelHeightValue.Text = trackHeight.Value.ToString();
        }

        private void initializeChildWindow()
        {
            //子ウィンドウの初期化
            child.Width = trackWidth.Value;
            child.Height = trackHeight.Value;
            child.BackColor = Color.FromArgb(trackColorR.Value, trackColorG.Value, trackColorB.Value);
        }

        private void checkShowWindow_CheckedChanged(object sender, EventArgs e)
        {
            //子ウィンドウ表示切り替え
            child.Visible = checkShowWindow.Checked;
        }

        private void buttonMoveController_Click(object sender, EventArgs e)
        {
            //移動ボタンコントローラ
            switch((sender as Button).Name)
            {
                case "buttonUp":
                    child.Location = new Point(child.Location.X, child.Location.Y - trackMoveDistance.Value);
                    break;
                case "buttonDown":
                    child.Location = new Point(child.Location.X, child.Location.Y + trackMoveDistance.Value);
                    break;
                case "buttonRight":
                    child.Location = new Point(child.Location.X + trackMoveDistance.Value, child.Location.Y);
                    break;
                case "buttonLeft":
                    child.Location = new Point(child.Location.X - trackMoveDistance.Value, child.Location.Y);
                    break;
                case "buttonCenter":
                    child.Location = new Point(trackWidth.Maximum/2, trackHeight.Maximum / 2);
                    break;
                default:
                    break;
            }
            
        }

        private void trackCoordinateController_Scroll(object sender, EventArgs e) {
            switch((sender as TrackBar).Name)
            {
                case "trackMoveDistance":
                    //移動量を設定
                    labelMoveDistanceValue.Text = trackMoveDistance.Value.ToString();
                    break;
                case "trackWidth":
                    //幅を設定
                    labelWidthValue.Text = trackWidth.Value.ToString();
                    child.Width = trackWidth.Value;
                    break;
                case "trackHeight":
                    //高さを設定
                    labelHeightValue.Text = trackHeight.Value.ToString();
                    child.Height = trackHeight.Value;
                    break;
                default:
                    break;
            }
        }

        private void trackColorController_Scroll(object sender, EventArgs e)
        {
            //子ウィンドウ背景色コントローラ
            switch((sender as TrackBar).Name)
            {
                case "trackColorR":
                    labelColorRValue.Text = trackColorR.Value.ToString();
                    break;
                case "trackColorG":
                    labelColorGValue.Text = trackColorG.Value.ToString();
                    break;
                case "trackColorB":
                    labelColorBValue.Text = trackColorB.Value.ToString();
                    break;
                default:
                    break;
            }
            child.BackColor = Color.FromArgb(trackColorR.Value, trackColorG.Value, trackColorB.Value);
        }
    }
}
