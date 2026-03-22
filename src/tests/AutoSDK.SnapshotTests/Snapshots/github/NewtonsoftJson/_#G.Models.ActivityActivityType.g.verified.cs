//HintName: G.Models.ActivityActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the activity that was performed.<br/>
    /// Example: force_push
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActivityActivityType
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="force_push")]
        ForcePush,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue_merge")]
        MergeQueueMerge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pr_merge")]
        PrMerge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="push")]
        Push,
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
                ActivityActivityType.BranchCreation => "branch_creation",
                ActivityActivityType.BranchDeletion => "branch_deletion",
                ActivityActivityType.ForcePush => "force_push",
                ActivityActivityType.MergeQueueMerge => "merge_queue_merge",
                ActivityActivityType.PrMerge => "pr_merge",
                ActivityActivityType.Push => "push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityActivityType? ToEnum(string value)
        {
            return value switch
            {
                "branch_creation" => ActivityActivityType.BranchCreation,
                "branch_deletion" => ActivityActivityType.BranchDeletion,
                "force_push" => ActivityActivityType.ForcePush,
                "merge_queue_merge" => ActivityActivityType.MergeQueueMerge,
                "pr_merge" => ActivityActivityType.PrMerge,
                "push" => ActivityActivityType.Push,
                _ => null,
            };
        }
    }
}