using AppDomainDLL;

namespace ClassLibrary1
{
    public class Class1 : IExtension
    {
        public string GetExtensionName()
        {
            return "first dll\n";
        }
    }
}
