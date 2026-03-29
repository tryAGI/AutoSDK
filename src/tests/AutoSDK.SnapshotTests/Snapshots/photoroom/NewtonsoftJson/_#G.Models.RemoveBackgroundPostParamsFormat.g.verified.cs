//HintName: G.Models.RemoveBackgroundPostParamsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the resulting image<br/>
    /// Default Value: png
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RemoveBackgroundPostParamsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpg")]
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webp")]
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RemoveBackgroundPostParamsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveBackgroundPostParamsFormat value)
        {
            return value switch
            {
                RemoveBackgroundPostParamsFormat.Jpg => "jpg",
                RemoveBackgroundPostParamsFormat.Png => "png",
                RemoveBackgroundPostParamsFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveBackgroundPostParamsFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpg" => RemoveBackgroundPostParamsFormat.Jpg,
                "png" => RemoveBackgroundPostParamsFormat.Png,
                "webp" => RemoveBackgroundPostParamsFormat.Webp,
                _ => null,
            };
        }
    }
}