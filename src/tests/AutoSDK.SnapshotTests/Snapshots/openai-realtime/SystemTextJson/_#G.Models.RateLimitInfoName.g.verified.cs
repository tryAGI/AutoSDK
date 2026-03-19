//HintName: G.Models.RateLimitInfoName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the rate limit.
    /// </summary>
    public enum RateLimitInfoName
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
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
                RateLimitInfoName.Requests => "requests",
                RateLimitInfoName.Tokens => "tokens",
                RateLimitInfoName.InputTokens => "input_tokens",
                RateLimitInfoName.OutputTokens => "output_tokens",
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
                "requests" => RateLimitInfoName.Requests,
                "tokens" => RateLimitInfoName.Tokens,
                "input_tokens" => RateLimitInfoName.InputTokens,
                "output_tokens" => RateLimitInfoName.OutputTokens,
                _ => null,
            };
        }
    }
}