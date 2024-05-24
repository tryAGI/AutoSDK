//HintName: G.Models.ActivityActivityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the activity that was performed.
    /// <br/>Example: force_push
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActivityActivityType
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
        [global::System.Runtime.Serialization.EnumMember(Value="branch_deletion")]
        BranchDeletion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch_creation")]
        BranchCreation,
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
}