//HintName: G.Models.UpscaleImageAccept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: application/json
    /// </summary>
    public enum UpscaleImageAccept
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
    public static class UpscaleImageAcceptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageAccept value)
        {
            return value switch
            {
                UpscaleImageAccept.ApplicationJson => "application/json",
                UpscaleImageAccept.ImagePng => "image/png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageAccept? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => UpscaleImageAccept.ApplicationJson,
                "image/png" => UpscaleImageAccept.ImagePng,
                _ => null,
            };
        }
    }
}