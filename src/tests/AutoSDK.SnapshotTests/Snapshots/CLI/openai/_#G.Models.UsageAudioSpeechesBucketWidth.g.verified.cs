//HintName: G.Models.UsageAudioSpeechesBucketWidth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: 1d
    /// </summary>
    public enum UsageAudioSpeechesBucketWidth
    {
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAudioSpeechesBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAudioSpeechesBucketWidth value)
        {
            return value switch
            {
                UsageAudioSpeechesBucketWidth.x1m => "1m",
                UsageAudioSpeechesBucketWidth.x1h => "1h",
                UsageAudioSpeechesBucketWidth.x1d => "1d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAudioSpeechesBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1m" => UsageAudioSpeechesBucketWidth.x1m,
                "1h" => UsageAudioSpeechesBucketWidth.x1h,
                "1d" => UsageAudioSpeechesBucketWidth.x1d,
                _ => null,
            };
        }
    }
}