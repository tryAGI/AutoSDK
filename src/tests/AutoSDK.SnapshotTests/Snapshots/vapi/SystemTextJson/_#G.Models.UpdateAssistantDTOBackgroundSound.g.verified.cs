//HintName: G.Models.UpdateAssistantDTOBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum UpdateAssistantDTOBackgroundSound
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        Office,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssistantDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateAssistantDTOBackgroundSound.Off => "off",
                UpdateAssistantDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateAssistantDTOBackgroundSound.Off,
                "office" => UpdateAssistantDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}