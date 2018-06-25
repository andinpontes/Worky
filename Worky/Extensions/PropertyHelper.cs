using System.Diagnostics;
using System.Text;

namespace Worky.Extensions
{
    public static class PropertyHelper
    {
        public static string CallerName()
        {
            StackFrame frame = new StackFrame(1);
            var method = frame.GetMethod();

            var sb = new StringBuilder(method.Name);
            sb.Replace("set_", "");
            sb.Replace("get_", "");

            return sb.ToString();
        }
    }
}
