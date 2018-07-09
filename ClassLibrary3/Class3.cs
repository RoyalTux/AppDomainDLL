using AppDomainDLL;

namespace ClassLibrary3
{
    public class Class3 : IExtension
    {
        public string GetExtensionName()
        {
            return "third dll\n";
        }
    }
}
