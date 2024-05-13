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
}