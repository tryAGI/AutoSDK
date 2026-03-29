//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the generation process.<br/>
    /// - `SUCCESS` indicates success<br/>
    /// - `ERROR` indicates an error<br/>
    /// - `CONTENT_FILTERED` indicates the result affected by the content filter and may be blurred.<br/>
    /// This header is only present when the `Accept` is set to `image/png`.  Otherwise it is returned in the response body.
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFiltered,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.ContentFiltered => "CONTENT_FILTERED",
                FinishReason.Error => "ERROR",
                FinishReason.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "CONTENT_FILTERED" => FinishReason.ContentFiltered,
                "ERROR" => FinishReason.Error,
                "SUCCESS" => FinishReason.Success,
                _ => null,
            };
        }
    }
}