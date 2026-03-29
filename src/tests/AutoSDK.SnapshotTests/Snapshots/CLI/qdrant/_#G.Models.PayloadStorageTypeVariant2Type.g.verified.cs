//HintName: G.Models.PayloadStorageTypeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PayloadStorageTypeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        OnDisk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadStorageTypeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadStorageTypeVariant2Type value)
        {
            return value switch
            {
                PayloadStorageTypeVariant2Type.OnDisk => "on_disk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadStorageTypeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "on_disk" => PayloadStorageTypeVariant2Type.OnDisk,
                _ => null,
            };
        }
    }
}