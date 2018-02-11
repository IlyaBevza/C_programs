using CommonSnappableTypes;
using System.Windows.Forms;

namespace CSharpSnapIn
{
    [CompanyInfo(CompanyName ="CSharp company",CompanyUrl ="www.yandex.ru")]
    public class CSharpModule:IPublicFuncionality
    {
        void IPublicFuncionality.DoIt() => MessageBox.Show("C Sharp module");
    }
}
