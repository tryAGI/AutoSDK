//HintName: G.Models.FeedsListSubscriptionHistoryResponseRunType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsListSubscriptionHistoryResponseRunType
    {
        /// <summary>
        /// 
        /// </summary>
        Backfill,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsListSubscriptionHistoryResponseRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsListSubscriptionHistoryResponseRunType value)
        {
            return value switch
            {
                FeedsListSubscriptionHistoryResponseRunType.Backfill => "backfill",
                FeedsListSubscriptionHistoryResponseRunType.Manual => "manual",
                FeedsListSubscriptionHistoryResponseRunType.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsListSubscriptionHistoryResponseRunType? ToEnum(string value)
        {
            return value switch
            {
                "backfill" => FeedsListSubscriptionHistoryResponseRunType.Backfill,
                "manual" => FeedsListSubscriptionHistoryResponseRunType.Manual,
                "scheduled" => FeedsListSubscriptionHistoryResponseRunType.Scheduled,
                _ => null,
            };
        }
    }
}