//HintName: G.Models.ReposListActivitiesActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListActivitiesActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        BranchCreation,
        /// <summary>
        /// 
        /// </summary>
        BranchDeletion,
        /// <summary>
        /// 
        /// </summary>
        ForcePush,
        /// <summary>
        /// 
        /// </summary>
        MergeQueueMerge,
        /// <summary>
        /// 
        /// </summary>
        PrMerge,
        /// <summary>
        /// 
        /// </summary>
        Push,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListActivitiesActivityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListActivitiesActivityType value)
        {
            return value switch
            {
                ReposListActivitiesActivityType.BranchCreation => "branch_creation",
                ReposListActivitiesActivityType.BranchDeletion => "branch_deletion",
                ReposListActivitiesActivityType.ForcePush => "force_push",
                ReposListActivitiesActivityType.MergeQueueMerge => "merge_queue_merge",
                ReposListActivitiesActivityType.PrMerge => "pr_merge",
                ReposListActivitiesActivityType.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListActivitiesActivityType? ToEnum(string value)
        {
            return value switch
            {
                "branch_creation" => ReposListActivitiesActivityType.BranchCreation,
                "branch_deletion" => ReposListActivitiesActivityType.BranchDeletion,
                "force_push" => ReposListActivitiesActivityType.ForcePush,
                "merge_queue_merge" => ReposListActivitiesActivityType.MergeQueueMerge,
                "pr_merge" => ReposListActivitiesActivityType.PrMerge,
                "push" => ReposListActivitiesActivityType.Push,
                _ => null,
            };
        }
    }
}