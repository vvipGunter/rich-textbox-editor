using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace gunterRichTextBoxEditor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //此下2项被赋值，但从未使用
        bool state = false;  
        string defaultPath = "";

        //    #region 新建一个记事本

        //    /// <summary>
        //    /// 
        //    /// </summary> 
        //    /// 
        //    public void New()  
        //    {
        //        OpenFileDialog myOpenFileDialog = new OpenFileDialog();
        //        myOpenFileDialog.Title = "输入新建文件名";
        //        myOpenFileDialog.InitialDirectory = "";
        //        myOpenFileDialog.Filter = "文本文件(*.txt)|所有文件(*.*)|*.txt|*.*";
        //        myOpenFileDialog.FilterIndex = 1;
        //        if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //                //OpenToolStripMenuItem.Text = "你输入文件是\n" + myOpenFileDialog.FileName;
        //                MessageBox.Show("请你输入你要新建记事本的名字:");
        //                string path = myOpenFileDialog.FileName;
        //                if (!File.Exists(path))
        //                {
        //                    File.Create("新建记事本.txt");
        //                }
        //                else
        //                {
        //                    using (StreamWriter witer1 = new StreamWriter(path))
        //                    {

        //                        witer1.Write("记事本新建并打开成功");
        //                        witer1.WriteLine("");
        //                        witer1.Close();
        //                    }
        //                }
        //        }
        //        else if( myOpenFileDialog.ShowDialog()==DialogResult.Cancel)
        //        {
        //            MessageBox.Show("你取消了操作！");
        //        }
        //    }
        //#endregion

        //#region 打开一个记事本
        ///// <summary>
        ///// 打开一个记事本
        ///// </summary>
        //public void Open()
        //{
        //    myRichTextBox.Text = "";
        //    OpenFileDialog MyOpenFileDialog = new OpenFileDialog();
        //    MyOpenFileDialog.Title = "选择打开文件";
        //    MyOpenFileDialog.InitialDirectory = "";
        //    MyOpenFileDialog.Filter = "文本文件(*.txt)|所有文件(*.*)|*.txt|*.*";
        //    MyOpenFileDialog.FilterIndex = 2;
        //    if (MyOpenFileDialog.ShowDialog() == DialogResult.OK)        //打开
        //    {
        //        // MessageBox.Show("请你输入你要新建记事本的名字");
        //        path = MyOpenFileDialog.FileName;
        //        if (!File.Exists(path))
        //        {

        //            // File.Create("another.txt");
        //        }
        //        else
        //        {

        //            //using (StreamWriter witer1 = new StreamWriter(path))
        //            //{
        //            //   // witer1.Write("记事本新建并打开成功");
        //            //   // witer1.WriteLine("take care of yourself!");
        //            //    //  myRichTextBox.AppendText(witer1.ToString());
        //            //    //myRichTextBox.Text = witer1.ToString();
        //            //    witer1.Close();
        //            //}
        //            using (StreamReader reader1 = new StreamReader(path))
        //            {
        //                if (File.Exists(path))
        //                {
        //                    myRichTextBox.Text = reader1.ReadToEnd();
        //                    reader1.Close();
        //                }
        //            }
        //        }
        //        // MessageBox.Show("新建记事本失败")

        //        // OpenToolStripMenuItem.Text = "你选择打开的文件是\n" + MyOpenFileDialog.FileName;
        //    }
        //    else if (MyOpenFileDialog.ShowDialog() == DialogResult.Cancel)       //取消
        //    {
        //        myRichTextBox.Text = "不打开已经存在的文件，新建一个！";
        //    }

        //}
        //#endregion

        #region 保存更改
        public void Save()
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.CreatePrompt = true;
            mySaveFileDialog.OverwritePrompt = true;
            mySaveFileDialog.RestoreDirectory = true;
            mySaveFileDialog.Title = "保存";
            mySaveFileDialog.InitialDirectory = "";
            mySaveFileDialog.DefaultExt.EndsWith(".rtf");
            mySaveFileDialog.Filter = "*.rtf";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mySaveFileDialog.RestoreDirectory = true;
                if (!File.Exists(mySaveFileDialog.FileName))
                {
                    FileStream fs = new FileStream(mySaveFileDialog.FileName, FileMode.CreateNew);
                    StreamWriter st = new StreamWriter(fs);
                    st.Write(myRichTextBox.Text);
                    st.Close();
                }
                else    //存在就新建一个
                {
                    MessageBox.Show("重名了！新建了一个名为：新建记事本.txt");
                    File.Create("新建记事本" + ".txt");
                }

                // SaveToolStripMenuItem.Text = "你想保存的文件为\n" + mySaveFileDialog.FileName;
            }
            else if (mySaveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                myRichTextBox.Clear();
                Application.Exit();
            }
        }
        /// <summary>
        /// 保存记事本的更改
        /// </summary>
        #endregion

        #region 当里面的文字发生更改时弹出警告框
        private void Warning()
        {

            MessageBox.Show("记事本中文字已经改变，是否保存?!", "友情提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            DialogResult gieguo = new DialogResult();
            if (myRichTextBox.Modified == true)
            {
                //Warning();
                if (gieguo == DialogResult.Yes)
                {
                    SaveYourWork();
                }
                else if (gieguo == DialogResult.No)
                {
                    myRichTextBox.Clear();
                    Application.Exit();
                }
                else if (gieguo == DialogResult.Cancel)
                    return;
            }
            //TextBox my = new TextBox();
            //if (!String.Equals(textBox1.Text.Length, my.Text.Length)) 
            //    Warning()

        }
        #endregion

        #region 判断当前的状态
        public bool StataNow()
        {
            RichTextBox mu = new RichTextBox();
            if (myRichTextBox.Text.Length > 0 && (myRichTextBox.Text.Length != mu.Text.Length))
            {
                return state = true;
                //Warning();
            }
            else return state = false;
        }
        #endregion

        #region 打开文件以便编辑
        /// <summary>
        /// 打开文件以便编辑
        /// </summary>
        private void OpenAFileForEdit()
        {
            string filePath = "";
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            myOpenFileDialog.ShowDialog();
            filePath = myOpenFileDialog.FileName;
            myRichTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
        }
        #endregion

        #region 保存所作的更改即保存当前的工作
        /// <summary>
        /// 保存所作的更改即保存当前的工作
        /// </summary>
        private void SaveYourWork()
        {
            string saveFileName = "";
            string finalSaveFileName = "";
            int pos = 0;
            //string fileType = "";
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.ShowDialog();
            saveFileName = mySaveFileDialog.FileName;                            //文件路径名
            finalSaveFileName = saveFileName.Substring(saveFileName.LastIndexOf("\\")+1);
            pos = saveFileName.LastIndexOf(".");
            if (pos == -1)
                finalSaveFileName += ".rtf";
            //fileType = saveFileName.Substring(saveFileName.LastIndexOf(".") + 1).ToLower();
            //MessageBox.Show("filanle:"+fileType+"fdsafd:"+pos+"finalfile:"+finalSaveFileName);
            //if (type == "")
            //    realSavePath += ".rtf";
            myRichTextBox.SaveFile(finalSaveFileName, RichTextBoxStreamType.RichText);
        }
        #endregion

        #region 把当前的工作另存为
        /// <summary>
        /// 把当前的工作另存为
        /// </summary>
        private void SaveAsYourWork()
        {
            string fullSavePath = "";
            string realSavePath = "";
            int pos = 0;
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            mySaveFileDialog.ShowDialog();
            fullSavePath = mySaveFileDialog.FileName;                            //文件路径名
            realSavePath = fullSavePath.Substring(fullSavePath.LastIndexOf("\\") + 1);
            pos = fullSavePath.LastIndexOf(".");
            // type = fullSavePath.Substring(fullSavePath.LastIndexOf(".") + 1).ToLower();        //文件格式 
            if (pos == -1)
                realSavePath += ".rtf";
            myRichTextBox.SaveFile(realSavePath, RichTextBoxStreamType.RichText);
        }
        #endregion


        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }

        private void aboutEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpTheme helpTheme = new HelpTheme();
            helpTheme.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //设置窗体大小
            myRichTextBox.Size = Home.ActiveForm.Size;
            myRichTextBox.Size = Home.ActiveForm.Size;
            //自动设置字体
            AutoSettingFontSize();
        }

        private void AutoSettingFontSize()
        {
            toolStripComboBox1.Items.Add("-请在下面选择字体-");
            int i = 0;
            float k = 0.0f;
            for (i = 1; i <= 200; i++)
            {
                k = k + 0.5f;
                toolStripComboBox1.Items.Add(k.ToString());
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myRichTextBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(myRichTextBox.Text!=""||myRichTextBox!=null)
            myRichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myRichTextBox.Text != "" || myRichTextBox != null)
            myRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myRichTextBox.Text != "" || myRichTextBox != null)
            myRichTextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //myRichTextBox.SelectedText.Remove();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myRichTextBox.SelectAll();
        }

        private void fontSettingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog myFontDialog = new FontDialog();
            myFontDialog.ShowDialog();
            myRichTextBox.SelectionFont = myFontDialog.Font;

            //保存当前的字体和样式
            using (MemoryStream ms = new MemoryStream())
            {
                if (ms.Length <= 300000)
                {
                    byte[] datas = ms.ToArray();
                    bool hasChanged = false;
                    hasChanged = myRichTextBox.Modified;
                    this.FindForm().DialogResult = DialogResult.OK;
                    //this.myRichTextBox.SaveFile(ms, RichTextBoxStreamType.RichText);
                    //this.myRichTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                    //if (hasChanged)
                    //    this.myRichTextBox.SaveFile(ms, RichTextBoxStreamType.RichText);

                    //else
                    //{
                    //    MessageBox.Show("文件没有更改，故不需要保存！","!");
                    //}
                }
                else
                {
                    MessageBox.Show("文件大小太大！", "!");
                }
            }
        }

        private void colorSettingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog myColorDialog = new ColorDialog();
            myColorDialog.ShowDialog();
            myRichTextBox.SelectionColor = myColorDialog.Color;
        }

        private void backGroudColorSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog myColorDialog = new ColorDialog();
            myColorDialog.ShowDialog();
            myRichTextBox.SelectionBackColor = myColorDialog.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myRichTextBox.Text = "";                                 //清空里面的文本
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAFileForEdit();                       //打开文件以便编辑
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveYourWork();
            MessageBox.Show("所作的更改已经保存！");
            Application.Exit();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsYourWork();
            MessageBox.Show("已经另存为！");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void underLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontSlopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            StataNow();
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            Font myfont = new Font("", float.Parse(toolStripComboBox1.Text.ToString()));

            myRichTextBox.SelectionFont = myfont;
        }

    }
}
