//HintName: G.Models.DocumentStoreStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the document store
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentStoreStatus
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