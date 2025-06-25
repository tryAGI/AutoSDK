﻿//HintName: G.Models.WebhookMergeGroupDestroyedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Explains why the merge group is being destroyed. The group could have been merged, removed from the queue (dequeued), or invalidated by an earlier queue entry being dequeued (invalidated).
    /// </summary>
    public enum WebhookMergeGroupDestroyedReason
    {
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Invalidated,
        /// <summary>
        /// 
        /// </summary>
        Dequeued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMergeGroupDestroyedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMergeGroupDestroyedReason value)
        {
            return value switch
            {
                WebhookMergeGroupDestroyedReason.Merged => "merged",
                WebhookMergeGroupDestroyedReason.Invalidated => "invalidated",
                WebhookMergeGroupDestroyedReason.Dequeued => "dequeued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMergeGroupDestroyedReason? ToEnum(string value)
        {
            return value switch
            {
                "merged" => WebhookMergeGroupDestroyedReason.Merged,
                "invalidated" => WebhookMergeGroupDestroyedReason.Invalidated,
                "dequeued" => WebhookMergeGroupDestroyedReason.Dequeued,
                _ => null,
            };
        }
    }
}