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
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Mid,
        /// <summary>
        /// 
        /// </summary>
        Ultra,
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
                ControlnetInputStrengthType.High => "High",
                ControlnetInputStrengthType.Low => "Low",
                ControlnetInputStrengthType.Max => "Max",
                ControlnetInputStrengthType.Mid => "Mid",
                ControlnetInputStrengthType.Ultra => "Ultra",
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
                "High" => ControlnetInputStrengthType.High,
                "Low" => ControlnetInputStrengthType.Low,
                "Max" => ControlnetInputStrengthType.Max,
                "Mid" => ControlnetInputStrengthType.Mid,
                "Ultra" => ControlnetInputStrengthType.Ultra,
                _ => null,
            };
        }
    }
}