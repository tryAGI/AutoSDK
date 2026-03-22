//HintName: G.Models.UltravoxV1SourceStatsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of this source, indicating whether it affects queries.
    /// </summary>
    public enum UltravoxV1SourceStatsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SourceStatusInitializing,
        /// <summary>
        /// 
        /// </summary>
        SourceStatusReady,
        /// <summary>
        /// 
        /// </summary>
        SourceStatusUnspecified,
        /// <summary>
        /// 
        /// </summary>
        SourceStatusUpdating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1SourceStatsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1SourceStatsStatus value)
        {
            return value switch
            {
                UltravoxV1SourceStatsStatus.SourceStatusInitializing => "SOURCE_STATUS_INITIALIZING",
                UltravoxV1SourceStatsStatus.SourceStatusReady => "SOURCE_STATUS_READY",
                UltravoxV1SourceStatsStatus.SourceStatusUnspecified => "SOURCE_STATUS_UNSPECIFIED",
                UltravoxV1SourceStatsStatus.SourceStatusUpdating => "SOURCE_STATUS_UPDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1SourceStatsStatus? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_STATUS_INITIALIZING" => UltravoxV1SourceStatsStatus.SourceStatusInitializing,
                "SOURCE_STATUS_READY" => UltravoxV1SourceStatsStatus.SourceStatusReady,
                "SOURCE_STATUS_UNSPECIFIED" => UltravoxV1SourceStatsStatus.SourceStatusUnspecified,
                "SOURCE_STATUS_UPDATING" => UltravoxV1SourceStatsStatus.SourceStatusUpdating,
                _ => null,
            };
        }
    }
}