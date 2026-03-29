//HintName: G.Models.CreateTextToVideoRequestSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to generate audio for the video.<br/>
    /// Default Value: off
    /// </summary>
    public enum CreateTextToVideoRequestSound
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestSound value)
        {
            return value switch
            {
                CreateTextToVideoRequestSound.Off => "off",
                CreateTextToVideoRequestSound.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateTextToVideoRequestSound.Off,
                "on" => CreateTextToVideoRequestSound.On,
                _ => null,
            };
        }
    }
}