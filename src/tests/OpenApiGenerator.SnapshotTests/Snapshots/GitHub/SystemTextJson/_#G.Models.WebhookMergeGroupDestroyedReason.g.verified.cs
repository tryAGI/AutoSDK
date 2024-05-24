//HintName: G.Models.WebhookMergeGroupDestroyedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Explains why the merge group is being destroyed. The group could have been merged, removed from the queue (dequeued), or invalidated by an earlier queue entry being dequeued (invalidated).
    /// </summary>
    public abstract class WebhookMergeGroupDestroyedReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Merged = "merged";
        /// <summary>
        /// 
        /// </summary>
        public const string Invalidated = "invalidated";
        /// <summary>
        /// 
        /// </summary>
        public const string Dequeued = "dequeued";
    }
}