//HintName: G.Models.PayloadStorageTypeVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PayloadStorageTypeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mmap")]
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PayloadStorageTypeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PayloadStorageTypeVariant3Type value)
        {
            return value switch
            {
                PayloadStorageTypeVariant3Type.Mmap => "mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PayloadStorageTypeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "mmap" => PayloadStorageTypeVariant3Type.Mmap,
                _ => null,
            };
        }
    }
}