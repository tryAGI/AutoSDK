//HintName: G.Models.GetRateLimitsPolicyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum GetRateLimitsPolicyStatus
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
    public static class GetRateLimitsPolicyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRateLimitsPolicyStatus value)
        {
            return value switch
            {
                GetRateLimitsPolicyStatus.Active => "active",
                GetRateLimitsPolicyStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRateLimitsPolicyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetRateLimitsPolicyStatus.Active,
                "archived" => GetRateLimitsPolicyStatus.Archived,
                _ => null,
            };
        }
    }
}