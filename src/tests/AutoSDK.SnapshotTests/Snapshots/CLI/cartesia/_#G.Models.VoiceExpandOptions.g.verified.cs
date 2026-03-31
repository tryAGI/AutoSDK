//HintName: G.Models.VoiceExpandOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceExpandOptions
    {
        /// <summary>
        /// 
        /// </summary>
        PreviewFileUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceExpandOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceExpandOptions value)
        {
            return value switch
            {
                VoiceExpandOptions.PreviewFileUrl => "preview_file_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceExpandOptions? ToEnum(string value)
        {
            return value switch
            {
                "preview_file_url" => VoiceExpandOptions.PreviewFileUrl,
                _ => null,
            };
        }
    }
}