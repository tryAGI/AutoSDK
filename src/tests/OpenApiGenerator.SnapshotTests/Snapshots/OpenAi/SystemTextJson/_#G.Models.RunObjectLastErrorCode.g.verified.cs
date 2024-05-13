//HintName: G.Models.RunObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
    /// </summary>
    public abstract class RunObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ServerError = "server_error";
        /// <summary>
        /// 
        /// </summary>
        public const string RateLimitExceeded = "rate_limit_exceeded";
        /// <summary>
        /// 
        /// </summary>
        public const string InvalidPrompt = "invalid_prompt";
    }
}