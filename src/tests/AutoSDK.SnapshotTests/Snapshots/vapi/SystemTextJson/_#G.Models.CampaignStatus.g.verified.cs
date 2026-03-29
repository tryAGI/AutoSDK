//HintName: G.Models.CampaignStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the campaign.
    /// </summary>
    public enum CampaignStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignStatus value)
        {
            return value switch
            {
                CampaignStatus.Ended => "ended",
                CampaignStatus.InProgress => "in-progress",
                CampaignStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => CampaignStatus.Ended,
                "in-progress" => CampaignStatus.InProgress,
                "scheduled" => CampaignStatus.Scheduled,
                _ => null,
            };
        }
    }
}