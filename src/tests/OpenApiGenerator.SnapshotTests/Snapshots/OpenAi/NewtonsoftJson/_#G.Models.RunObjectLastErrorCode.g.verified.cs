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
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_exceeded")]
        RateLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_prompt")]
        InvalidPrompt,
    }

    public static class RunObjectLastErrorCodeExtensions
    {
        public static string ToValueString(this RunObjectLastErrorCode value)
        {
            return value switch
            {
                RunObjectLastErrorCode.ServerError => "server_error",
                RunObjectLastErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                RunObjectLastErrorCode.InvalidPrompt => "invalid_prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectLastErrorCode ToEnum(string value)
        {
            return value switch
            {
                "server_error" => RunObjectLastErrorCode.ServerError,
                "rate_limit_exceeded" => RunObjectLastErrorCode.RateLimitExceeded,
                "invalid_prompt" => RunObjectLastErrorCode.InvalidPrompt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectLastErrorCode ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectLastErrorCode.ServerError,
                1 => RunObjectLastErrorCode.RateLimitExceeded,
                2 => RunObjectLastErrorCode.InvalidPrompt,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}