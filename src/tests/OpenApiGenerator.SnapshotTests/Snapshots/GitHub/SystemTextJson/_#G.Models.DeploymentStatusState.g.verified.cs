//HintName: G.Models.DeploymentStatusState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the status.
    /// <br/>Example: success
    /// </summary>
    public abstract class DeploymentStatusState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Error = "error";
        /// <summary>
        /// 
        /// </summary>
        public const string Failure = "failure";
        /// <summary>
        /// 
        /// </summary>
        public const string Inactive = "inactive";
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
        public const string Queued = "queued";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
    }
}