﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2009, Daniel Kollmann
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, are permitted
// provided that the following conditions are met:
//
// - Redistributions of source code must retain the above copyright notice, this list of conditions
//   and the following disclaimer.
//
// - Redistributions in binary form must reproduce the above copyright notice, this list of
//   conditions and the following disclaimer in the documentation and/or other materials provided
//   with the distribution.
//
// - Neither the name of Daniel Kollmann nor the names of its contributors may be used to endorse
//   or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
// IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY
// WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
////////////////////////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// The above software in this distribution may have been modified by THL A29 Limited ("Tencent Modifications").
//
// All Tencent Modifications are Copyright (C) 2015 THL A29 Limited.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Behaviac.Design
{
    partial class NodeTreeList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeTreeList));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.expandButton = new System.Windows.Forms.ToolStripButton();
            this.collapseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.debugLabel = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.debugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.treeView.ForeColor = System.Drawing.Color.LightGray;
            this.treeView.ImageList = this.imageList;
            this.treeView.Name = "treeView";
            this.toolTip.SetToolTip(this.treeView, resources.GetString("treeView.ToolTip"));
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            this.treeView.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseUp);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList.Images.SetKeyName(0, "flag_blue");
            this.imageList.Images.SetKeyName(1, "flag_green");
            this.imageList.Images.SetKeyName(2, "flag_red");
            this.imageList.Images.SetKeyName(3, "behavior");
            this.imageList.Images.SetKeyName(4, "behavior_loaded");
            this.imageList.Images.SetKeyName(5, "behavior_modified");
            this.imageList.Images.SetKeyName(6, "condition");
            this.imageList.Images.SetKeyName(7, "time");
            this.imageList.Images.SetKeyName(8, "action");
            this.imageList.Images.SetKeyName(9, "decorator");
            this.imageList.Images.SetKeyName(10, "sequence");
            this.imageList.Images.SetKeyName(11, "selector");
            this.imageList.Images.SetKeyName(12, "parallel");
            this.imageList.Images.SetKeyName(13, "folder_closed");
            this.imageList.Images.SetKeyName(14, "folder_open");
            this.imageList.Images.SetKeyName(15, "event");
            this.imageList.Images.SetKeyName(16, "override");
            this.imageList.Images.SetKeyName(17, "primitiveTask");
            this.imageList.Images.SetKeyName(18, "compoundTask");
            this.imageList.Images.SetKeyName(19, "method");
            this.imageList.Images.SetKeyName(20, "precondition");
            this.imageList.Images.SetKeyName(21, "operator");
            this.imageList.Images.SetKeyName(22, "prefab");
            this.imageList.Images.SetKeyName(23, "and");
            this.imageList.Images.SetKeyName(24, "or");
            this.imageList.Images.SetKeyName(25, "not");
            this.imageList.Images.SetKeyName(26, "false");
            this.imageList.Images.SetKeyName(27, "true");
            this.imageList.Images.SetKeyName(28, "assignment");
            this.imageList.Images.SetKeyName(29, "noop");
            this.imageList.Images.SetKeyName(30, "wait");
            this.imageList.Images.SetKeyName(31, "query");
            this.imageList.Images.SetKeyName(32, "eventHandle");
            this.imageList.Images.SetKeyName(33, "loop");
            this.imageList.Images.SetKeyName(34, "loopUntil");
            this.imageList.Images.SetKeyName(35, "log");
            this.imageList.Images.SetKeyName(36, "waitFrame");
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandButton,
            this.collapseButton,
            this.toolStripSeparator1,
            this.cancelButton,
            this.debugLabel});
            this.toolStrip.Name = "toolStrip";
            this.toolTip.SetToolTip(this.toolStrip, resources.GetString("toolStrip.ToolTip"));
            // 
            // expandButton
            // 
            resources.ApplyResources(this.expandButton, "expandButton");
            this.expandButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.expandButton.Name = "expandButton";
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // collapseButton
            // 
            resources.ApplyResources(this.collapseButton, "collapseButton");
            this.collapseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // debugLabel
            // 
            resources.ApplyResources(this.debugLabel, "debugLabel");
            this.debugLabel.ForeColor = System.Drawing.Color.LightGray;
            this.debugLabel.Name = "debugLabel";
            // 
            // contextMenuStrip
            // 
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.BackColor = System.Drawing.Color.DarkGray;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugMenuItem,
            this.toolStripSeparator2,
            this.parMenuItem,
            this.parameterMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.toolTip.SetToolTip(this.contextMenuStrip, resources.GetString("contextMenuStrip.ToolTip"));
            // 
            // debugMenuItem
            // 
            resources.ApplyResources(this.debugMenuItem, "debugMenuItem");
            this.debugMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.debugMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.debugMenuItem.Name = "debugMenuItem";
            this.debugMenuItem.Click += new System.EventHandler(this.debugMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // parMenuItem
            // 
            resources.ApplyResources(this.parMenuItem, "parMenuItem");
            this.parMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.parMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.parMenuItem.Name = "parMenuItem";
            this.parMenuItem.Click += new System.EventHandler(this.parMenuItem_Click);
            // 
            // parameterMenuItem
            // 
            resources.ApplyResources(this.parameterMenuItem, "parameterMenuItem");
            this.parameterMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.parameterMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.parameterMenuItem.Name = "parameterMenuItem";
            this.parameterMenuItem.Click += new System.EventHandler(this.parameterMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 400;
            // 
            // NodeTreeList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.toolStrip);
            this.Name = "NodeTreeList";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton expandButton;
        private System.Windows.Forms.ToolStripButton collapseButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem parameterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel debugLabel;
        private System.Windows.Forms.ToolStripMenuItem parMenuItem;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
