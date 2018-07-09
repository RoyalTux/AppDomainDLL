using AppDomainDLL;

namespace ClassLibrary2
{
    public class Class2 : IExtension
    {
        public string GetExtensionName()
        {
            return "second dll\n";
        }
    }
}
