//HintName: G.Models.LiquidConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type discriminator for liquid condition<br/>
    /// Example: liquid
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LiquidConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="liquid")]
        Liquid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiquidConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiquidConditionType value)
        {
            return value switch
            {
                LiquidConditionType.Liquid => "liquid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiquidConditionType? ToEnum(string value)
        {
            return value switch
            {
                "liquid" => LiquidConditionType.Liquid,
                _ => null,
            };
        }
    }
}