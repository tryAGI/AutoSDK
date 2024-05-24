//HintName: G.Models.ActivityActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the activity that was performed.
    /// <br/>Example: force_push
    /// </summary>
    public abstract class ActivityActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Push = "push";
        /// <summary>
        /// 
        /// </summary>
        public const string ForcePush = "force_push";
        /// <summary>
        /// 
        /// </summary>
        public const string BranchDeletion = "branch_deletion";
        /// <summary>
        /// 
        /// </summary>
        public const string BranchCreation = "branch_creation";
        /// <summary>
        /// 
        /// </summary>
        public const string PrMerge = "pr_merge";
        /// <summary>
        /// 
        /// </summary>
        public const string MergeQueueMerge = "merge_queue_merge";
    }
}