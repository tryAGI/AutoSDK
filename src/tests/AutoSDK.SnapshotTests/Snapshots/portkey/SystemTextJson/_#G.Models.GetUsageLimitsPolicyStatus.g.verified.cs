//HintName: G.Models.GetUsageLimitsPolicyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum GetUsageLimitsPolicyStatus
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
    public static class GetUsageLimitsPolicyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageLimitsPolicyStatus value)
        {
            return value switch
            {
                GetUsageLimitsPolicyStatus.Active => "active",
                GetUsageLimitsPolicyStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageLimitsPolicyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetUsageLimitsPolicyStatus.Active,
                "archived" => GetUsageLimitsPolicyStatus.Archived,
                _ => null,
            };
        }
    }
}