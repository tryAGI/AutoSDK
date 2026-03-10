//HintName: G.Models.BodyStreamComposedMusicV1MusicStreamPostModelId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyStreamComposedMusicV1MusicStreamPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        MusicV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyStreamComposedMusicV1MusicStreamPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyStreamComposedMusicV1MusicStreamPostModelId value)
        {
            return value switch
            {
                BodyStreamComposedMusicV1MusicStreamPostModelId.MusicV1 => "music_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyStreamComposedMusicV1MusicStreamPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyStreamComposedMusicV1MusicStreamPostModelId.MusicV1,
                _ => null,
            };
        }
    }
}