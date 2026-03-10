//HintName: G.Models.BodyComposeMusicV1MusicPostModelId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    public enum BodyComposeMusicV1MusicPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        MusicV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyComposeMusicV1MusicPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyComposeMusicV1MusicPostModelId value)
        {
            return value switch
            {
                BodyComposeMusicV1MusicPostModelId.MusicV1 => "music_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyComposeMusicV1MusicPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyComposeMusicV1MusicPostModelId.MusicV1,
                _ => null,
            };
        }
    }
}