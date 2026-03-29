//HintName: G.Models.ImageRenderingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageRenderingMode
    {
        /// <summary>
        /// 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blocked")]
        Blocked,
        /// <summary>
        /// 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="click_to_load")]
        ClickToLoad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRenderingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRenderingMode value)
        {
            return value switch
            {
                ImageRenderingMode.Auto => "auto",
                ImageRenderingMode.Blocked => "blocked",
                ImageRenderingMode.ClickToLoad => "click_to_load",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRenderingMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageRenderingMode.Auto,
                "blocked" => ImageRenderingMode.Blocked,
                "click_to_load" => ImageRenderingMode.ClickToLoad,
                _ => null,
            };
        }
    }
}