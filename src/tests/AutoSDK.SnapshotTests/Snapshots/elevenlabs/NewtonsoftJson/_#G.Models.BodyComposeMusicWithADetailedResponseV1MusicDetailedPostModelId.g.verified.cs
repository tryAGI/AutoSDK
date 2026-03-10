//HintName: G.Models.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for the generation.<br/>
    /// Default Value: music_v1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="music_v1")]
        MusicV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId value)
        {
            return value switch
            {
                BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId.MusicV1 => "music_v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "music_v1" => BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId.MusicV1,
                _ => null,
            };
        }
    }
}