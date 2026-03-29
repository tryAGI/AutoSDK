//HintName: G.Models.HlsObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A string representing the encoding status of the video file from its original format to a streamable format.<br/>
    /// **Values**:<br/>
    /// - `PROCESSING`: Video is currently being encoded and is not yet ready for streaming<br/>
    /// - `COMPLETE`: Encoding has successfully finished and the video is ready for streaming<br/>
    /// - `CANCELED`: Encoding was manually canceled before completion<br/>
    /// - `ERROR`: An error occurred during the encoding process
    /// </summary>
    public enum HlsObjectStatus
    {
        /// <summary>
        /// Encoding was manually canceled before completion
        /// </summary>
        Canceled,
        /// <summary>
        /// Encoding has successfully finished and the video is ready for streaming
        /// </summary>
        Complete,
        /// <summary>
        /// An error occurred during the encoding process
        /// </summary>
        Error,
        /// <summary>
        /// Video is currently being encoded and is not yet ready for streaming
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HlsObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HlsObjectStatus value)
        {
            return value switch
            {
                HlsObjectStatus.Canceled => "CANCELED",
                HlsObjectStatus.Complete => "COMPLETE",
                HlsObjectStatus.Error => "ERROR",
                HlsObjectStatus.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HlsObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => HlsObjectStatus.Canceled,
                "COMPLETE" => HlsObjectStatus.Complete,
                "ERROR" => HlsObjectStatus.Error,
                "PROCESSING" => HlsObjectStatus.Processing,
                _ => null,
            };
        }
    }
}