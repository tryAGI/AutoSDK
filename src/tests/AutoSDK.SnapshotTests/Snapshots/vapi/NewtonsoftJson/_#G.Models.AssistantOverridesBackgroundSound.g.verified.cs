//HintName: G.Models.AssistantOverridesBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantOverridesBackgroundSound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="office")]
        Office,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantOverridesBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantOverridesBackgroundSound value)
        {
            return value switch
            {
                AssistantOverridesBackgroundSound.Off => "off",
                AssistantOverridesBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantOverridesBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => AssistantOverridesBackgroundSound.Off,
                "office" => AssistantOverridesBackgroundSound.Office,
                _ => null,
            };
        }
    }
}