//HintName: G.Models.CreateAvatarResponseDtoObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    public enum CreateAvatarResponseDtoObject
    {
        /// <summary>
        /// 
        /// </summary>
        SceneAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAvatarResponseDtoObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAvatarResponseDtoObject value)
        {
            return value switch
            {
                CreateAvatarResponseDtoObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAvatarResponseDtoObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => CreateAvatarResponseDtoObject.SceneAvatar,
                _ => null,
            };
        }
    }
}