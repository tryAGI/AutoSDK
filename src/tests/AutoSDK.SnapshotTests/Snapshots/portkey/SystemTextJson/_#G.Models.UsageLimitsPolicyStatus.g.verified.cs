//HintName: G.Models.UsageLimitsPolicyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy status
    /// </summary>
    public enum UsageLimitsPolicyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitsPolicyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitsPolicyStatus value)
        {
            return value switch
            {
                UsageLimitsPolicyStatus.Active => "active",
                UsageLimitsPolicyStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitsPolicyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UsageLimitsPolicyStatus.Active,
                "archived" => UsageLimitsPolicyStatus.Archived,
                _ => null,
            };
        }
    }
}