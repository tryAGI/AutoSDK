//HintName: G.Models.RunObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_prompt")]
        InvalidPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_exceeded")]
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectLastErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectLastErrorCode value)
        {
            return value switch
            {
                RunObjectLastErrorCode.InvalidPrompt => "invalid_prompt",
                RunObjectLastErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                RunObjectLastErrorCode.ServerError => "server_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectLastErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_prompt" => RunObjectLastErrorCode.InvalidPrompt,
                "rate_limit_exceeded" => RunObjectLastErrorCode.RateLimitExceeded,
                "server_error" => RunObjectLastErrorCode.ServerError,
                _ => null,
            };
        }
    }
}