﻿//HintName: G.Models.ThinkingConfigParamDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ThinkingConfigParamDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingConfigParamDiscriminatorType value)
        {
            return value switch
            {
                ThinkingConfigParamDiscriminatorType.Disabled => "disabled",
                ThinkingConfigParamDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ThinkingConfigParamDiscriminatorType.Disabled,
                "enabled" => ThinkingConfigParamDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}