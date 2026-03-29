//HintName: G.Models.GetAvatarsResponseAvatarObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatarsResponseAvatarObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scene_avatar")]
        SceneAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarsResponseAvatarObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarsResponseAvatarObject value)
        {
            return value switch
            {
                GetAvatarsResponseAvatarObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarsResponseAvatarObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => GetAvatarsResponseAvatarObject.SceneAvatar,
                _ => null,
            };
        }
    }
}