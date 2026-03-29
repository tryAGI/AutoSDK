//HintName: G.Models.EditImageGetLightingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetLightingMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.auto")]
        AiAuto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.preserve-hue-and-saturation")]
        AiPreserveHueAndSaturation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetLightingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetLightingMode value)
        {
            return value switch
            {
                EditImageGetLightingMode.AiAuto => "ai.auto",
                EditImageGetLightingMode.AiPreserveHueAndSaturation => "ai.preserve-hue-and-saturation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetLightingMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.auto" => EditImageGetLightingMode.AiAuto,
                "ai.preserve-hue-and-saturation" => EditImageGetLightingMode.AiPreserveHueAndSaturation,
                _ => null,
            };
        }
    }
}