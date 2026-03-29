//HintName: G.Models.SparseVectorStorageTypeVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage on disk (rocksdb storage)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SparseVectorStorageTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on_disk")]
        OnDisk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseVectorStorageTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseVectorStorageTypeVariant1 value)
        {
            return value switch
            {
                SparseVectorStorageTypeVariant1.OnDisk => "on_disk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseVectorStorageTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "on_disk" => SparseVectorStorageTypeVariant1.OnDisk,
                _ => null,
            };
        }
    }
}