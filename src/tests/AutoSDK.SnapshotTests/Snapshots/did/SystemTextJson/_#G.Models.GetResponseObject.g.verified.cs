//HintName: G.Models.GetResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this avatar
    /// </summary>
    public enum GetResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        SceneAvatar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseObject value)
        {
            return value switch
            {
                GetResponseObject.SceneAvatar => "scene_avatar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "scene_avatar" => GetResponseObject.SceneAvatar,
                _ => null,
            };
        }
    }
}