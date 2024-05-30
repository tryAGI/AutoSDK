//HintName: G.Models.RunStepObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepObjectLastErrorCode
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
    }

    public static class RunStepObjectLastErrorCodeExtensions
    {
        public static string ToValueString(this RunStepObjectLastErrorCode value)
        {
            return value switch
            {
                RunStepObjectLastErrorCode.ServerError => "server_error",
                RunStepObjectLastErrorCode.RateLimitExceeded => "rate_limit_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectLastErrorCode ToEnum(string value)
        {
            return value switch
            {
                "server_error" => RunStepObjectLastErrorCode.ServerError,
                "rate_limit_exceeded" => RunStepObjectLastErrorCode.RateLimitExceeded,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepObjectLastErrorCode ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepObjectLastErrorCode.ServerError,
                1 => RunStepObjectLastErrorCode.RateLimitExceeded,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}