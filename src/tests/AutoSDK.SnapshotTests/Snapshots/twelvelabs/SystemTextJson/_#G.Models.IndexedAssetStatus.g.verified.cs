//HintName: G.Models.IndexedAssetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the indexing task.
    /// </summary>
    public enum IndexedAssetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexedAssetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexedAssetStatus value)
        {
            return value switch
            {
                IndexedAssetStatus.Failed => "failed",
                IndexedAssetStatus.Indexing => "indexing",
                IndexedAssetStatus.Pending => "pending",
                IndexedAssetStatus.Queued => "queued",
                IndexedAssetStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexedAssetStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => IndexedAssetStatus.Failed,
                "indexing" => IndexedAssetStatus.Indexing,
                "pending" => IndexedAssetStatus.Pending,
                "queued" => IndexedAssetStatus.Queued,
                "ready" => IndexedAssetStatus.Ready,
                _ => null,
            };
        }
    }
}