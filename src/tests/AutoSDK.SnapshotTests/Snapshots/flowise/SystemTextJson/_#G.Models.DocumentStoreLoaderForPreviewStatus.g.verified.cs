//HintName: G.Models.DocumentStoreLoaderForPreviewStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the document store loader
    /// </summary>
    public enum DocumentStoreLoaderForPreviewStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Empty,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        Sync,
        /// <summary>
        /// 
        /// </summary>
        Syncing,
        /// <summary>
        /// 
        /// </summary>
        Upserted,
        /// <summary>
        /// 
        /// </summary>
        Upserting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStoreLoaderForPreviewStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreLoaderForPreviewStatus value)
        {
            return value switch
            {
                DocumentStoreLoaderForPreviewStatus.Empty => "EMPTY",
                DocumentStoreLoaderForPreviewStatus.New => "NEW",
                DocumentStoreLoaderForPreviewStatus.Stale => "STALE",
                DocumentStoreLoaderForPreviewStatus.Sync => "SYNC",
                DocumentStoreLoaderForPreviewStatus.Syncing => "SYNCING",
                DocumentStoreLoaderForPreviewStatus.Upserted => "UPSERTED",
                DocumentStoreLoaderForPreviewStatus.Upserting => "UPSERTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreLoaderForPreviewStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreLoaderForPreviewStatus.Empty,
                "NEW" => DocumentStoreLoaderForPreviewStatus.New,
                "STALE" => DocumentStoreLoaderForPreviewStatus.Stale,
                "SYNC" => DocumentStoreLoaderForPreviewStatus.Sync,
                "SYNCING" => DocumentStoreLoaderForPreviewStatus.Syncing,
                "UPSERTED" => DocumentStoreLoaderForPreviewStatus.Upserted,
                "UPSERTING" => DocumentStoreLoaderForPreviewStatus.Upserting,
                _ => null,
            };
        }
    }
}