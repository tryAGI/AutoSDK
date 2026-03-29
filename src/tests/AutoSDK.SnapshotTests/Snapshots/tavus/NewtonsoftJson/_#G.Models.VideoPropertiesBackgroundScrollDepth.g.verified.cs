//HintName: G.Models.VideoPropertiesBackgroundScrollDepth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoPropertiesBackgroundScrollDepth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom")]
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="middle")]
        Middle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoPropertiesBackgroundScrollDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPropertiesBackgroundScrollDepth value)
        {
            return value switch
            {
                VideoPropertiesBackgroundScrollDepth.Bottom => "bottom",
                VideoPropertiesBackgroundScrollDepth.Middle => "middle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPropertiesBackgroundScrollDepth? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => VideoPropertiesBackgroundScrollDepth.Bottom,
                "middle" => VideoPropertiesBackgroundScrollDepth.Middle,
                _ => null,
            };
        }
    }
}