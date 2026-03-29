//HintName: G.Models.Create1ResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create1ResponseObject
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
    public static class Create1ResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create1ResponseObject value)
        {
            return value switch
            {
                Create1ResponseObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create1ResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => Create1ResponseObject.SceneAvatar,
                _ => null,
            };
        }
    }
}