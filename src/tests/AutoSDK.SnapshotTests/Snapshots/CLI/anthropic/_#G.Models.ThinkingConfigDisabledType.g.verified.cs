﻿//HintName: G.Models.ThinkingConfigDisabledType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThinkingConfigDisabledType
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingConfigDisabledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingConfigDisabledType value)
        {
            return value switch
            {
                ThinkingConfigDisabledType.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingConfigDisabledType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ThinkingConfigDisabledType.Disabled,
                _ => null,
            };
        }
    }
}