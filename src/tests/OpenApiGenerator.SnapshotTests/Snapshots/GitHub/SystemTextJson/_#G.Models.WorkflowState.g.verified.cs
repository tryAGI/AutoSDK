//HintName: G.Models.WorkflowState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: active
    /// </summary>
    public abstract class WorkflowState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Active = "active";
        /// <summary>
        /// 
        /// </summary>
        public const string Deleted = "deleted";
        /// <summary>
        /// 
        /// </summary>
        public const string DisabledFork = "disabled_fork";
        /// <summary>
        /// 
        /// </summary>
        public const string DisabledInactivity = "disabled_inactivity";
        /// <summary>
        /// 
        /// </summary>
        public const string DisabledManually = "disabled_manually";
    }
}