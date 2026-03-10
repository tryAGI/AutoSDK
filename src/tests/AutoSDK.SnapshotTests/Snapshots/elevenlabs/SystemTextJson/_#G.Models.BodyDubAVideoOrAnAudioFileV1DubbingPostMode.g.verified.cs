//HintName: G.Models.BodyDubAVideoOrAnAudioFileV1DubbingPostMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode in which to run this Dubbing job. Defaults to automatic, use manual if specifically providing a CSV transcript to use. Note that manual mode is experimental and production use is strongly discouraged.<br/>
    /// Default Value: automatic
    /// </summary>
    public enum BodyDubAVideoOrAnAudioFileV1DubbingPostMode
    {
        /// <summary>
        /// 
        /// </summary>
        Automatic,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyDubAVideoOrAnAudioFileV1DubbingPostModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyDubAVideoOrAnAudioFileV1DubbingPostMode value)
        {
            return value switch
            {
                BodyDubAVideoOrAnAudioFileV1DubbingPostMode.Automatic => "automatic",
                BodyDubAVideoOrAnAudioFileV1DubbingPostMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyDubAVideoOrAnAudioFileV1DubbingPostMode? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => BodyDubAVideoOrAnAudioFileV1DubbingPostMode.Automatic,
                "manual" => BodyDubAVideoOrAnAudioFileV1DubbingPostMode.Manual,
                _ => null,
            };
        }
    }
}