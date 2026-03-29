//HintName: G.Models.VectorStorageTypeVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage in memory (RAM)<br/>
    /// Will be very fast at the cost of consuming a lot of memory.
    /// </summary>
    public enum VectorStorageTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Memory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant1 value)
        {
            return value switch
            {
                VectorStorageTypeVariant1.Memory => "Memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "Memory" => VectorStorageTypeVariant1.Memory,
                _ => null,
            };
        }
    }
}