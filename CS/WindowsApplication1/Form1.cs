using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
    }

    public class MyListBoxViewInfo: BaseListBoxViewInfo {
        public MyListBoxViewInfo(BaseListBoxControl c)
            : base(c) {
        }
        protected override bool CalcVScrollVisibility(Rectangle bounds) {
            return true;
        }
    }
    public class MyListBoxControl: ListBoxControl {
        public MyListBoxControl()
            : base() {
        }
        protected override BaseStyleControlViewInfo CreateViewInfo() {
            return new MyListBoxViewInfo(this);
        }
    
    }
}