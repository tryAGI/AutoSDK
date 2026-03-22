//HintName: G.Models.RateLimitInfoName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the rate limit.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RateLimitInfoName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_tokens")]
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_tokens")]
        OutputTokens,
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
    public static class RateLimitInfoNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitInfoName value)
        {
            return value switch
            {
                RateLimitInfoName.InputTokens => "input_tokens",
                RateLimitInfoName.OutputTokens => "output_tokens",
                RateLimitInfoName.Requests => "requests",
                RateLimitInfoName.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitInfoName? ToEnum(string value)
        {
            return value switch
            {
                "input_tokens" => RateLimitInfoName.InputTokens,
                "output_tokens" => RateLimitInfoName.OutputTokens,
                "requests" => RateLimitInfoName.Requests,
                "tokens" => RateLimitInfoName.Tokens,
                _ => null,
            };
        }
    }
}