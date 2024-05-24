//HintName: G.Models.EnvironmentApprovalsState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether deployment to the environment(s) was approved or rejected or pending (with comments)
    /// <br/>Example: approved
    /// </summary>
    public abstract class EnvironmentApprovalsState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Approved = "approved";
        /// <summary>
        /// 
        /// </summary>
        public const string Rejected = "rejected";
        /// <summary>
        /// 
        /// </summary>
        public const string Pending = "pending";
    }
}