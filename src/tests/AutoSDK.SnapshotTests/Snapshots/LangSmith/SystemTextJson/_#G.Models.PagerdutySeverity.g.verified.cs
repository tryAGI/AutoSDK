//HintName: G.Models.PagerdutySeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for severity.
    /// </summary>
    public enum PagerdutySeverity
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PagerdutySeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PagerdutySeverity value)
        {
            return value switch
            {
                PagerdutySeverity.Critical => "critical",
                PagerdutySeverity.Warning => "warning",
                PagerdutySeverity.Error => "error",
                PagerdutySeverity.Info => "info",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PagerdutySeverity? ToEnum(string value)
        {
            return value switch
            {
                "critical" => PagerdutySeverity.Critical,
                "warning" => PagerdutySeverity.Warning,
                "error" => PagerdutySeverity.Error,
                "info" => PagerdutySeverity.Info,
                _ => null,
            };
        }
    }
}