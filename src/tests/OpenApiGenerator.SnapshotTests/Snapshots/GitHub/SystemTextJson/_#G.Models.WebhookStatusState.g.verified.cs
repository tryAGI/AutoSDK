//HintName: G.Models.WebhookStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The new state. Can be `pending`, `success`, `failure`, or `error`.
    /// </summary>
    public abstract class WebhookStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
        /// <summary>
        /// 
        /// </summary>
        public const string Success = "success";
        /// <summary>
        /// 
        /// </summary>
        public const string Failure = "failure";
        /// <summary>
        /// 
        /// </summary>
        public const string Error = "error";
    }
}