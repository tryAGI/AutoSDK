//HintName: G.Models.TextToImageAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    public enum TextToImageAccept
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageAccept value)
        {
            return value switch
            {
                TextToImageAccept.ApplicationJson => "application/json",
                TextToImageAccept.ImagePng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => TextToImageAccept.ApplicationJson,
                "image/png" => TextToImageAccept.ImagePng,
                _ => null,
            };
        }
    }
}