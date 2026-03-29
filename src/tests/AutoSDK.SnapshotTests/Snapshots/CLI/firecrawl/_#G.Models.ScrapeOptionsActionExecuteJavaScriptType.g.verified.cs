//HintName: G.Models.ScrapeOptionsActionExecuteJavaScriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Execute JavaScript code on the page
    /// </summary>
    public enum ScrapeOptionsActionExecuteJavaScriptType
    {
        /// <summary>
        /// 
        /// </summary>
        ExecuteJavascript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionExecuteJavaScriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionExecuteJavaScriptType value)
        {
            return value switch
            {
                ScrapeOptionsActionExecuteJavaScriptType.ExecuteJavascript => "executeJavascript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionExecuteJavaScriptType? ToEnum(string value)
        {
            return value switch
            {
                "executeJavascript" => ScrapeOptionsActionExecuteJavaScriptType.ExecuteJavascript,
                _ => null,
            };
        }
    }
}