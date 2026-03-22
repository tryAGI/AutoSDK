//HintName: G.Models.UltravoxV1CorpusStatsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of this corpus, indicating whether it is queryable.
    /// </summary>
    public enum UltravoxV1CorpusStatsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CorpusStatusEmpty,
        /// <summary>
        /// 
        /// </summary>
        CorpusStatusInitializing,
        /// <summary>
        /// 
        /// </summary>
        CorpusStatusReady,
        /// <summary>
        /// 
        /// </summary>
        CorpusStatusUnspecified,
        /// <summary>
        /// 
        /// </summary>
        CorpusStatusUpdating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1CorpusStatsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CorpusStatsStatus value)
        {
            return value switch
            {
                UltravoxV1CorpusStatsStatus.CorpusStatusEmpty => "CORPUS_STATUS_EMPTY",
                UltravoxV1CorpusStatsStatus.CorpusStatusInitializing => "CORPUS_STATUS_INITIALIZING",
                UltravoxV1CorpusStatsStatus.CorpusStatusReady => "CORPUS_STATUS_READY",
                UltravoxV1CorpusStatsStatus.CorpusStatusUnspecified => "CORPUS_STATUS_UNSPECIFIED",
                UltravoxV1CorpusStatsStatus.CorpusStatusUpdating => "CORPUS_STATUS_UPDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CorpusStatsStatus? ToEnum(string value)
        {
            return value switch
            {
                "CORPUS_STATUS_EMPTY" => UltravoxV1CorpusStatsStatus.CorpusStatusEmpty,
                "CORPUS_STATUS_INITIALIZING" => UltravoxV1CorpusStatsStatus.CorpusStatusInitializing,
                "CORPUS_STATUS_READY" => UltravoxV1CorpusStatsStatus.CorpusStatusReady,
                "CORPUS_STATUS_UNSPECIFIED" => UltravoxV1CorpusStatsStatus.CorpusStatusUnspecified,
                "CORPUS_STATUS_UPDATING" => UltravoxV1CorpusStatsStatus.CorpusStatusUpdating,
                _ => null,
            };
        }
    }
}