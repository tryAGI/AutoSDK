//HintName: G.Models.VectorStorageTypeVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage in a single mmap file, not appendable Pre-fetched into RAM on load
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStorageTypeVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InRamMmap")]
        InRamMmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant5 value)
        {
            return value switch
            {
                VectorStorageTypeVariant5.InRamMmap => "InRamMmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "InRamMmap" => VectorStorageTypeVariant5.InRamMmap,
                _ => null,
            };
        }
    }
}