//HintName: G.Models.ImageGenToolModeration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Moderation level for the generated image. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolModeration
    {
        /// <summary>
        /// `auto`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolModeration value)
        {
            return value switch
            {
                ImageGenToolModeration.Auto => "auto",
                ImageGenToolModeration.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolModeration? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenToolModeration.Auto,
                "low" => ImageGenToolModeration.Low,
                _ => null,
            };
        }
    }
}