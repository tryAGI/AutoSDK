//HintName: G.Models.SecurityFilterPlanMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mode of operation when a security threat is detected.<br/>
    /// - 'sanitize': Remove or replace the threatening content<br/>
    /// - 'reject': Replace the entire transcript with replacement text<br/>
    /// - 'replace': Replace threatening patterns with replacement text<br/>
    /// @default 'sanitize'<br/>
    /// Default Value: sanitize
    /// </summary>
    public enum SecurityFilterPlanMode
    {
        /// <summary>
        /// Replace the entire transcript with replacement text
        /// </summary>
        Reject,
        /// <summary>
        /// Remove or replace the threatening content
        /// </summary>
        Replace,
        /// <summary>
        /// Remove or replace the threatening content
        /// </summary>
        Sanitize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityFilterPlanModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityFilterPlanMode value)
        {
            return value switch
            {
                SecurityFilterPlanMode.Reject => "reject",
                SecurityFilterPlanMode.Replace => "replace",
                SecurityFilterPlanMode.Sanitize => "sanitize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityFilterPlanMode? ToEnum(string value)
        {
            return value switch
            {
                "reject" => SecurityFilterPlanMode.Reject,
                "replace" => SecurityFilterPlanMode.Replace,
                "sanitize" => SecurityFilterPlanMode.Sanitize,
                _ => null,
            };
        }
    }
}