//HintName: G.Models.DubbedAssetInProgressStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: in_progress
    /// </summary>
    public enum DubbedAssetInProgressStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbedAssetInProgressStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbedAssetInProgressStatus value)
        {
            return value switch
            {
                DubbedAssetInProgressStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbedAssetInProgressStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => DubbedAssetInProgressStatus.InProgress,
                _ => null,
            };
        }
    }
}