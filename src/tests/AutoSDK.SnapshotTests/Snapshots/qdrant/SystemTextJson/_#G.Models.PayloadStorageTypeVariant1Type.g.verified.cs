//HintName: G.Models.PayloadStorageTypeVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PayloadStorageTypeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        InMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadStorageTypeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadStorageTypeVariant1Type value)
        {
            return value switch
            {
                PayloadStorageTypeVariant1Type.InMemory => "in_memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadStorageTypeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "in_memory" => PayloadStorageTypeVariant1Type.InMemory,
                _ => null,
            };
        }
    }
}