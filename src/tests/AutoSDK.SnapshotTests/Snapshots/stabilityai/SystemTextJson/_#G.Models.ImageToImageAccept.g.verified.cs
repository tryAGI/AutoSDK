//HintName: G.Models.ImageToImageAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    public enum ImageToImageAccept
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
    public static class ImageToImageAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToImageAccept value)
        {
            return value switch
            {
                ImageToImageAccept.ApplicationJson => "application/json",
                ImageToImageAccept.ImagePng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToImageAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => ImageToImageAccept.ApplicationJson,
                "image/png" => ImageToImageAccept.ImagePng,
                _ => null,
            };
        }
    }
}