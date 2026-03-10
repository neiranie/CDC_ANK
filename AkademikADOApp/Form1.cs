using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=LAPTOP-9BPMNG3K\\ANNEIRA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn;
