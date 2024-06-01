//HintName: G.Models.ReposListActivitiesActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListActivitiesActivityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="force_push")]
        ForcePush,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_creation")]
        BranchCreation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_deletion")]
        BranchDeletion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pr_merge")]
        PrMerge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue_merge")]
        MergeQueueMerge,
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
                ReposListActivitiesActivityType.Push => "push",
                ReposListActivitiesActivityType.ForcePush => "force_push",
                ReposListActivitiesActivityType.BranchCreation => "branch_creation",
                ReposListActivitiesActivityType.BranchDeletion => "branch_deletion",
                ReposListActivitiesActivityType.PrMerge => "pr_merge",
                ReposListActivitiesActivityType.MergeQueueMerge => "merge_queue_merge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListActivitiesActivityType ToEnum(string value)
        {
            return value switch
            {
                "push" => ReposListActivitiesActivityType.Push,
                "force_push" => ReposListActivitiesActivityType.ForcePush,
                "branch_creation" => ReposListActivitiesActivityType.BranchCreation,
                "branch_deletion" => ReposListActivitiesActivityType.BranchDeletion,
                "pr_merge" => ReposListActivitiesActivityType.PrMerge,
                "merge_queue_merge" => ReposListActivitiesActivityType.MergeQueueMerge,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}