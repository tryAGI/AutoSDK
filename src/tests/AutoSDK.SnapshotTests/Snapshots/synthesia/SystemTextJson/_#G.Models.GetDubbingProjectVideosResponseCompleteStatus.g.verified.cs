//HintName: G.Models.GetDubbingProjectVideosResponseCompleteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: complete
    /// </summary>
    public enum GetDubbingProjectVideosResponseCompleteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingProjectVideosResponseCompleteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingProjectVideosResponseCompleteStatus value)
        {
            return value switch
            {
                GetDubbingProjectVideosResponseCompleteStatus.Complete => "complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingProjectVideosResponseCompleteStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GetDubbingProjectVideosResponseCompleteStatus.Complete,
                _ => null,
            };
        }
    }
}