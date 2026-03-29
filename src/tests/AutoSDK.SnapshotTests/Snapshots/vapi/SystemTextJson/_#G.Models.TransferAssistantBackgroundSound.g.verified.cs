//HintName: G.Models.TransferAssistantBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    public enum TransferAssistantBackgroundSound
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
    public static class TransferAssistantBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferAssistantBackgroundSound value)
        {
            return value switch
            {
                TransferAssistantBackgroundSound.Off => "off",
                TransferAssistantBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferAssistantBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => TransferAssistantBackgroundSound.Off,
                "office" => TransferAssistantBackgroundSound.Office,
                _ => null,
            };
        }
    }
}