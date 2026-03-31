//HintName: G.Models.GetAvatarResponseDtoObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    public enum GetAvatarResponseDtoObject
    {
        /// <summary>
        /// 
        /// </summary>
        SceneAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarResponseDtoObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarResponseDtoObject value)
        {
            return value switch
            {
                GetAvatarResponseDtoObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarResponseDtoObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => GetAvatarResponseDtoObject.SceneAvatar,
                _ => null,
            };
        }
    }
}