//HintName: G.Models.ControlnetInputStrengthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strength type for the controlnet. Can only be used for Style, Character and Content Reference controlnets.
    /// </summary>
    public enum ControlnetInputStrengthType
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Mid,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ControlnetInputStrengthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ControlnetInputStrengthType value)
        {
            return value switch
            {
                ControlnetInputStrengthType.Low => "Low",
                ControlnetInputStrengthType.Mid => "Mid",
                ControlnetInputStrengthType.High => "High",
                ControlnetInputStrengthType.Ultra => "Ultra",
                ControlnetInputStrengthType.Max => "Max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ControlnetInputStrengthType? ToEnum(string value)
        {
            return value switch
            {
                "Low" => ControlnetInputStrengthType.Low,
                "Mid" => ControlnetInputStrengthType.Mid,
                "High" => ControlnetInputStrengthType.High,
                "Ultra" => ControlnetInputStrengthType.Ultra,
                "Max" => ControlnetInputStrengthType.Max,
                _ => null,
            };
        }
    }
}