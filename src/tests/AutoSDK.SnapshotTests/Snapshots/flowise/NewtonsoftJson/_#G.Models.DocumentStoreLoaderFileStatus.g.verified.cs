//HintName: G.Models.DocumentStoreLoaderFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentStoreLoaderFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EMPTY")]
        Empty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEW")]
        New,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STALE")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYNC")]
        Sync,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYNCING")]
        Syncing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPSERTED")]
        Upserted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPSERTING")]
        Upserting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStoreLoaderFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStoreLoaderFileStatus value)
        {
            return value switch
            {
                DocumentStoreLoaderFileStatus.Empty => "EMPTY",
                DocumentStoreLoaderFileStatus.New => "NEW",
                DocumentStoreLoaderFileStatus.Stale => "STALE",
                DocumentStoreLoaderFileStatus.Sync => "SYNC",
                DocumentStoreLoaderFileStatus.Syncing => "SYNCING",
                DocumentStoreLoaderFileStatus.Upserted => "UPSERTED",
                DocumentStoreLoaderFileStatus.Upserting => "UPSERTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStoreLoaderFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "EMPTY" => DocumentStoreLoaderFileStatus.Empty,
                "NEW" => DocumentStoreLoaderFileStatus.New,
                "STALE" => DocumentStoreLoaderFileStatus.Stale,
                "SYNC" => DocumentStoreLoaderFileStatus.Sync,
                "SYNCING" => DocumentStoreLoaderFileStatus.Syncing,
                "UPSERTED" => DocumentStoreLoaderFileStatus.Upserted,
                "UPSERTING" => DocumentStoreLoaderFileStatus.Upserting,
                _ => null,
            };
        }
    }
}