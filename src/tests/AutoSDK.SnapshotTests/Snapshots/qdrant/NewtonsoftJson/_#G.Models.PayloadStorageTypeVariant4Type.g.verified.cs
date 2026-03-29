//HintName: G.Models.PayloadStorageTypeVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PayloadStorageTypeVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_ram_mmap")]
        InRamMmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadStorageTypeVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadStorageTypeVariant4Type value)
        {
            return value switch
            {
                PayloadStorageTypeVariant4Type.InRamMmap => "in_ram_mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadStorageTypeVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "in_ram_mmap" => PayloadStorageTypeVariant4Type.InRamMmap,
                _ => null,
            };
        }
    }
}