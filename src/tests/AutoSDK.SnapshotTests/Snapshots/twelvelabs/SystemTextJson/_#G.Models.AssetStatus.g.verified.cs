//HintName: G.Models.AssetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the current status of the asset.<br/>
    /// **Values**:<br/>
    /// - `failed`: The platform failed to process the upload<br/>
    /// - `processing`: The platform is processing the uploaded file<br/>
    /// - `ready`: The asset is ready to use
    /// </summary>
    public enum AssetStatus
    {
        /// <summary>
        /// The platform failed to process the upload
        /// </summary>
        Failed,
        /// <summary>
        /// The platform is processing the uploaded file
        /// </summary>
        Processing,
        /// <summary>
        /// The asset is ready to use
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetStatus value)
        {
            return value switch
            {
                AssetStatus.Failed => "failed",
                AssetStatus.Processing => "processing",
                AssetStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AssetStatus.Failed,
                "processing" => AssetStatus.Processing,
                "ready" => AssetStatus.Ready,
                _ => null,
            };
        }
    }
}