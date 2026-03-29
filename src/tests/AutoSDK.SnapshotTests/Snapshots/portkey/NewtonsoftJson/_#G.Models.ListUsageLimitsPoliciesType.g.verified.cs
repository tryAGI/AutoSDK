//HintName: G.Models.ListUsageLimitsPoliciesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListUsageLimitsPoliciesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokens")]
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListUsageLimitsPoliciesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListUsageLimitsPoliciesType value)
        {
            return value switch
            {
                ListUsageLimitsPoliciesType.Cost => "cost",
                ListUsageLimitsPoliciesType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListUsageLimitsPoliciesType? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ListUsageLimitsPoliciesType.Cost,
                "tokens" => ListUsageLimitsPoliciesType.Tokens,
                _ => null,
            };
        }
    }
}