//HintName: G.Models.GetDubbingProjectVideosResponseErrorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: error
    /// </summary>
    public enum GetDubbingProjectVideosResponseErrorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDubbingProjectVideosResponseErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDubbingProjectVideosResponseErrorStatus value)
        {
            return value switch
            {
                GetDubbingProjectVideosResponseErrorStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDubbingProjectVideosResponseErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetDubbingProjectVideosResponseErrorStatus.Error,
                _ => null,
            };
        }
    }
}