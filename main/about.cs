using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quanlithuvientruongdaihoc
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*label1.Text = "1. Cung cấp cho người quản lý các thông tin về các đầu sách trong thư viện, các đầu sách theo từng thể loại, số sách đang được mượn, số sách rỗi (chưa được mượn)….";
                           "2. Hỗ trợ việc quản lý thông tin về bạn đọc. " +
                            "3. Hỗ trợ cập nhật các thông tin về tài liệu và bạn đọc như: các lần tái bản, thêm sách, thêm bạn đọc, xóa bạn đọc, thay đổi thông tin tài liệu, thay đổi thông tin bạn đọc…. " +
                            "4. Hỗ trợ người quản lý trong quá trình xác nhận cho mượn và trả sách với bạn đọc. " +
                            "5. Hỗ trợ nhiều người dùng làm việc đồng thời. " +
                            "6. Hệ thống phải hoạt động liên tục 8 giờ / ngày, 6 ngày / tuần, với thời gian ngừng hoạt động không quá 10 %. " +
                            "7. Hệ thống phải hỗ trợ đến 30 người dùng truy xuất CSDL trung tâm đồng thời bất kỳ lúc nào. " +
                            "8. Hệ thống phải có khả năng hoàn tất 80 % giao dịch trong vòng 2 phút";*/
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "1. Cung cấp cho người quản lý các thông tin về các đầu sách trong thư viện, các đầu sách theo từng thể loại, số sách đang được mượn, số sách rỗi (chưa được mượn)…." +
            "2. Hỗ trợ việc quản lý thông tin về bạn đọc. " +
             "3. Hỗ trợ cập nhật các thông tin về tài liệu và bạn đọc như: các lần tái bản, thêm sách, thêm bạn đọc, xóa bạn đọc, thay đổi thông tin tài liệu, thay đổi thông tin bạn đọc…. " +
             "4. Hỗ trợ người quản lý trong quá trình xác nhận cho mượn và trả sách với bạn đọc. " +
             "5. Hỗ trợ nhiều người dùng làm việc đồng thời. " +
             "6. Hệ thống phải hoạt động liên tục 8 giờ / ngày, 6 ngày / tuần, với thời gian ngừng hoạt động không quá 10 %. " +
             "7. Hệ thống phải hỗ trợ đến 30 người dùng truy xuất CSDL trung tâm đồng thời bất kỳ lúc nào. " +
             "8. Hệ thống phải có khả năng hoàn tất 80 % giao dịch trong vòng 2 phút";
        }
    }
}
