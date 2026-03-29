//HintName: G.Models.GetDubbingProjectVideosResponseInProgressStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: in_progress
    /// </summary>
    public enum GetDubbingProjectVideosResponseInProgressStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingProjectVideosResponseInProgressStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingProjectVideosResponseInProgressStatus value)
        {
            return value switch
            {
                GetDubbingProjectVideosResponseInProgressStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingProjectVideosResponseInProgressStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => GetDubbingProjectVideosResponseInProgressStatus.InProgress,
                _ => null,
            };
        }
    }
}