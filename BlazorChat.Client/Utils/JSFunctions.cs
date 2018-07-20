using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorChat.Client.Utils
{
    public static class JSFunctions
    {
        public static void Alert(string message)
        {
            RegisteredFunction.Invoke<bool>("Alert", message);
        }
    }
}
