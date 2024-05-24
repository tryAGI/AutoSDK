//HintName: G.Models.WebhookMergeGroupDestroyedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Explains why the merge group is being destroyed. The group could have been merged, removed from the queue (dequeued), or invalidated by an earlier queue entry being dequeued (invalidated).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMergeGroupDestroyedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merged")]
        Merged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalidated")]
        Invalidated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dequeued")]
        Dequeued,
    }
}