//HintName: G.Models.GetAvatarsResponseDtoAvatarObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    public enum GetAvatarsResponseDtoAvatarObject
    {
        /// <summary>
        /// 
        /// </summary>
        SceneAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarsResponseDtoAvatarObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseDtoAvatarObject value)
        {
            return value switch
            {
                GetAvatarsResponseDtoAvatarObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseDtoAvatarObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => GetAvatarsResponseDtoAvatarObject.SceneAvatar,
                _ => null,
            };
        }
    }
}