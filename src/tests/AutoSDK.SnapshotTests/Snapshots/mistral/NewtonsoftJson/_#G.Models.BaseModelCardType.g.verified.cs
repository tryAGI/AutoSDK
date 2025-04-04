﻿//HintName: G.Models.BaseModelCardType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: base
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseModelCardType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base")]
        Base,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseModelCardTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseModelCardType value)
        {
            return value switch
            {
                BaseModelCardType.Base => "base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseModelCardType? ToEnum(string value)
        {
            return value switch
            {
                "base" => BaseModelCardType.Base,
                _ => null,
            };
        }
    }
}