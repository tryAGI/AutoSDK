//HintName: G.Models.VideoPropertiesBackgroundScrollType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoPropertiesBackgroundScrollType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="human")]
        Human,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smooth")]
        Smooth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoPropertiesBackgroundScrollTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoPropertiesBackgroundScrollType value)
        {
            return value switch
            {
                VideoPropertiesBackgroundScrollType.Human => "human",
                VideoPropertiesBackgroundScrollType.Smooth => "smooth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoPropertiesBackgroundScrollType? ToEnum(string value)
        {
            return value switch
            {
                "human" => VideoPropertiesBackgroundScrollType.Human,
                "smooth" => VideoPropertiesBackgroundScrollType.Smooth,
                _ => null,
            };
        }
    }
}