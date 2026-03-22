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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
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
                PagerdutySeverity.Error => "error",
                PagerdutySeverity.Info => "info",
                PagerdutySeverity.Warning => "warning",
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
                "error" => PagerdutySeverity.Error,
                "info" => PagerdutySeverity.Info,
                "warning" => PagerdutySeverity.Warning,
                _ => null,
            };
        }
    }
}