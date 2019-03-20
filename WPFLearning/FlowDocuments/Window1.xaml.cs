using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowDocuments
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Paragraph para1 = new Paragraph();
            para1.Inlines.Add("WPF divides documents into two broad categories based on their intended use; these document categories are termed \"fixed documents\" and \"flow documents.\"");
            doc.Blocks.Add(para1);

            Paragraph para2 = new Paragraph();
            para2.Inlines.Add("Fixed documents are intended for applications that require a precise \"what you see is what you get\" (WYSIWYG) presentation, independent of the display or printer hardware used. Typical uses for fixed documents include desktop publishing, word processing, and form layout, where adherence to the original page design is critical. As part of its layout, a fixed document maintains the precise positional placement of content elements independent of the display or print device in use. For example, a fixed document page viewed on 96 dpi display will appear exactly the same when it is output to a 600 dpi laser printer as when it is output to a 4800 dpi phototypesetter. The page layout remains the same in all cases, while the document quality maximizes to the capabilities of each device.");
            doc.Blocks.Add(para2);

            Paragraph para3 = new Paragraph();
            para3.Inlines.Add("By comparison, flow documents are designed to optimize viewing and readability and are best utilized when ease of reading is the primary document consumption scenario. Rather than being set to one predefined layout, flow documents dynamically adjust and reflow their content based on run-time variables such as window size, device resolution, and optional user preferences. A Web page is a simple example of a flow document where the page content is dynamically formatted to fit the current window. Flow documents optimize the viewing and reading experience for the user, based on the runtime environment. For example, the same flow document will dynamically reformat for optimal readability on either high-resolution 19-inch display or a small 2x3-inch PDA screen. In addition, flow documents have a number of built in features including search, viewing modes that optimize readability, and the ability to change the size and appearance of fonts. See Flow Document Overview for illustrations, examples, and in-depth information on flow documents.");
            doc.Blocks.Add(para3);
        }
    }
}
