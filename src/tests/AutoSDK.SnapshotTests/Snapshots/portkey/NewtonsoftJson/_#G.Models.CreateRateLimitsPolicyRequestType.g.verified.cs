//HintName: G.Models.CreateRateLimitsPolicyRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRateLimitsPolicyRequestType
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
    public static class CreateRateLimitsPolicyRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRateLimitsPolicyRequestType value)
        {
            return value switch
            {
                CreateRateLimitsPolicyRequestType.Requests => "requests",
                CreateRateLimitsPolicyRequestType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRateLimitsPolicyRequestType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => CreateRateLimitsPolicyRequestType.Requests,
                "tokens" => CreateRateLimitsPolicyRequestType.Tokens,
                _ => null,
            };
        }
    }
}