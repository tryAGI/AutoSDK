﻿//HintName: G.Models.OwnershipEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OwnershipEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OwnershipEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OwnershipEnum value)
        {
            return value switch
            {
                OwnershipEnum.Public => "public",
                OwnershipEnum.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OwnershipEnum? ToEnum(string value)
        {
            return value switch
            {
                "public" => OwnershipEnum.Public,
                "private" => OwnershipEnum.Private,
                _ => null,
            };
        }
    }
}