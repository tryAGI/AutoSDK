//HintName: G.Models.DocumentStoreStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the document store
    /// </summary>
    public enum DocumentStoreStatus
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
    public static class DocumentStoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreStatus value)
        {
            return value switch
            {
                DocumentStoreStatus.Empty => "EMPTY",
                DocumentStoreStatus.New => "NEW",
                DocumentStoreStatus.Stale => "STALE",
                DocumentStoreStatus.Sync => "SYNC",
                DocumentStoreStatus.Syncing => "SYNCING",
                DocumentStoreStatus.Upserted => "UPSERTED",
                DocumentStoreStatus.Upserting => "UPSERTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreStatus.Empty,
                "NEW" => DocumentStoreStatus.New,
                "STALE" => DocumentStoreStatus.Stale,
                "SYNC" => DocumentStoreStatus.Sync,
                "SYNCING" => DocumentStoreStatus.Syncing,
                "UPSERTED" => DocumentStoreStatus.Upserted,
                "UPSERTING" => DocumentStoreStatus.Upserting,
                _ => null,
            };
        }
    }
}