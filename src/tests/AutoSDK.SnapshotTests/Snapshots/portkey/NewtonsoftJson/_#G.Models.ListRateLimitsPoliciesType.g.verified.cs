//HintName: G.Models.ListRateLimitsPoliciesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRateLimitsPoliciesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requests")]
        Requests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokens")]
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRateLimitsPoliciesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRateLimitsPoliciesType value)
        {
            return value switch
            {
                ListRateLimitsPoliciesType.Requests => "requests",
                ListRateLimitsPoliciesType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRateLimitsPoliciesType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => ListRateLimitsPoliciesType.Requests,
                "tokens" => ListRateLimitsPoliciesType.Tokens,
                _ => null,
            };
        }
    }
}