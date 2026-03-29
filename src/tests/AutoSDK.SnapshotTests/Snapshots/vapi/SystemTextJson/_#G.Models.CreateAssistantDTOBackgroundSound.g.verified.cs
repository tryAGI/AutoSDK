//HintName: G.Models.CreateAssistantDTOBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum CreateAssistantDTOBackgroundSound
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
    public static class CreateAssistantDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOBackgroundSound value)
        {
            return value switch
            {
                CreateAssistantDTOBackgroundSound.Off => "off",
                CreateAssistantDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateAssistantDTOBackgroundSound.Off,
                "office" => CreateAssistantDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}