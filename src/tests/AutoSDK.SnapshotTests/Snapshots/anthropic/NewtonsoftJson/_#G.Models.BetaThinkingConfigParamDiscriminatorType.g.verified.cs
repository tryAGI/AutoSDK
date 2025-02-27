//HintName: G.Models.BetaThinkingConfigParamDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaThinkingConfigParamDiscriminatorType
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
    public static class BetaThinkingConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaThinkingConfigParamDiscriminatorType value)
        {
            return value switch
            {
                BetaThinkingConfigParamDiscriminatorType.Disabled => "disabled",
                BetaThinkingConfigParamDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaThinkingConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaThinkingConfigParamDiscriminatorType.Disabled,
                "enabled" => BetaThinkingConfigParamDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}