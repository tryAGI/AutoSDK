//HintName: G.Models.ListRateLimitsPoliciesUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRateLimitsPoliciesUnit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rpd")]
        Rpd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rph")]
        Rph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rpm")]
        Rpm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRateLimitsPoliciesUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRateLimitsPoliciesUnit value)
        {
            return value switch
            {
                ListRateLimitsPoliciesUnit.Rpd => "rpd",
                ListRateLimitsPoliciesUnit.Rph => "rph",
                ListRateLimitsPoliciesUnit.Rpm => "rpm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRateLimitsPoliciesUnit? ToEnum(string value)
        {
            return value switch
            {
                "rpd" => ListRateLimitsPoliciesUnit.Rpd,
                "rph" => ListRateLimitsPoliciesUnit.Rph,
                "rpm" => ListRateLimitsPoliciesUnit.Rpm,
                _ => null,
            };
        }
    }
}