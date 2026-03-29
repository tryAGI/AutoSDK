//HintName: G.Models.BlobStorageExportMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlobStorageExportMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_CUSTOM_DATE")]
        FromCustomDate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_TODAY")]
        FromToday,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULL_HISTORY")]
        FullHistory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlobStorageExportModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlobStorageExportMode value)
        {
            return value switch
            {
                BlobStorageExportMode.FromCustomDate => "FROM_CUSTOM_DATE",
                BlobStorageExportMode.FromToday => "FROM_TODAY",
                BlobStorageExportMode.FullHistory => "FULL_HISTORY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlobStorageExportMode? ToEnum(string value)
        {
            return value switch
            {
                "FROM_CUSTOM_DATE" => BlobStorageExportMode.FromCustomDate,
                "FROM_TODAY" => BlobStorageExportMode.FromToday,
                "FULL_HISTORY" => BlobStorageExportMode.FullHistory,
                _ => null,
            };
        }
    }
}