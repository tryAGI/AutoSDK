//HintName: G.Models.AnnotationQueueItemsFilterAnnotationStatesVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueItemsFilterAnnotationStatesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Unstarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueItemsFilterAnnotationStatesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueItemsFilterAnnotationStatesVariant1Item value)
        {
            return value switch
            {
                AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Completed => "completed",
                AnnotationQueueItemsFilterAnnotationStatesVariant1Item.InProgress => "in_progress",
                AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Skipped => "skipped",
                AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Unstarted => "unstarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueItemsFilterAnnotationStatesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Completed,
                "in_progress" => AnnotationQueueItemsFilterAnnotationStatesVariant1Item.InProgress,
                "skipped" => AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Skipped,
                "unstarted" => AnnotationQueueItemsFilterAnnotationStatesVariant1Item.Unstarted,
                _ => null,
            };
        }
    }
}