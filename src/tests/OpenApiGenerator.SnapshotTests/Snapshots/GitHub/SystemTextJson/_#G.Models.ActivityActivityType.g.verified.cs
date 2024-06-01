//HintName: G.Models.ActivityActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the activity that was performed.
    /// <br/>Example: force_push
    /// </summary>
    public enum ActivityActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        ForcePush,
        /// <summary>
        /// 
        /// </summary>
        BranchDeletion,
        /// <summary>
        /// 
        /// </summary>
        BranchCreation,
        /// <summary>
        /// 
        /// </summary>
        PrMerge,
        /// <summary>
        /// 
        /// </summary>
        MergeQueueMerge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityActivityType value)
        {
            return value switch
            {
                ActivityActivityType.Push => "push",
                ActivityActivityType.ForcePush => "force_push",
                ActivityActivityType.BranchDeletion => "branch_deletion",
                ActivityActivityType.BranchCreation => "branch_creation",
                ActivityActivityType.PrMerge => "pr_merge",
                ActivityActivityType.MergeQueueMerge => "merge_queue_merge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityActivityType ToEnum(string value)
        {
            return value switch
            {
                "push" => ActivityActivityType.Push,
                "force_push" => ActivityActivityType.ForcePush,
                "branch_deletion" => ActivityActivityType.BranchDeletion,
                "branch_creation" => ActivityActivityType.BranchCreation,
                "pr_merge" => ActivityActivityType.PrMerge,
                "merge_queue_merge" => ActivityActivityType.MergeQueueMerge,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}