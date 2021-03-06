﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.SaleManage;

namespace SALE.UI.SaleManage
{
    public partial class FormRetailUntreadRefundBill : Form
    {
        public FormRetailUntreadRefundBill()
        {
            InitializeComponent();
        }

        private void FormRetailUntreadRefundBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode3, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            cbds.DataGridViewComboBoxColumnBindDataSource(PayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            cbds.DataGridViewComboBoxColumnBindDataSource(BankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailUntreadRefundBillInput formRetailUntreadRefundBillInput = new FormRetailUntreadRefundBillInput();
            formRetailUntreadRefundBillInput.Tag = "Add";
            formRetailUntreadRefundBillInput.Owner = this;
            formRetailUntreadRefundBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvUntreadRefundBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvUntreadRefundBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailUntreadRefundBillInput formRetailUntreadRefundBillInput = new FormRetailUntreadRefundBillInput();
                formRetailUntreadRefundBillInput.Tag = "Edit";
                formRetailUntreadRefundBillInput.Owner = this;
                formRetailUntreadRefundBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailUntreadRefundBill formBrowseRetailUntreadRefundBill = new FormBrowseRetailUntreadRefundBill();
            formBrowseRetailUntreadRefundBill.Owner = this;
            formBrowseRetailUntreadRefundBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvUntreadRefundBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvUntreadRefundBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RetailUntreadRefundBill rurb = new RetailUntreadRefundBill();
                DataGridViewRow dgvr = dgvUntreadRefundBill.CurrentRow;
                int intId = Convert.ToInt32(dgvr.Cells["Id"].Value);
                String strSql = "Delete From UntreadRefundBill Where Id = " + intId;
                if (rurb.Delete(strSql))
                {
                    dgvUntreadRefundBill.Rows.Remove(dgvr);
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUntreadRefundBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
