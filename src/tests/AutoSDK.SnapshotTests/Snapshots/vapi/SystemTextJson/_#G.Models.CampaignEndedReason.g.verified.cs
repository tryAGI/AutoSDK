//HintName: G.Models.CampaignEndedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the explanation for how the campaign ended.
    /// </summary>
    public enum CampaignEndedReason
    {
        /// <summary>
        /// 
        /// </summary>
        CampaignEndedSuccess,
        /// <summary>
        /// 
        /// </summary>
        CampaignInProgressEndedByUser,
        /// <summary>
        /// 
        /// </summary>
        CampaignScheduledEndedByUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignEndedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignEndedReason value)
        {
            return value switch
            {
                CampaignEndedReason.CampaignEndedSuccess => "campaign.ended.success",
                CampaignEndedReason.CampaignInProgressEndedByUser => "campaign.in-progress.ended-by-user",
                CampaignEndedReason.CampaignScheduledEndedByUser => "campaign.scheduled.ended-by-user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignEndedReason? ToEnum(string value)
        {
            return value switch
            {
                "campaign.ended.success" => CampaignEndedReason.CampaignEndedSuccess,
                "campaign.in-progress.ended-by-user" => CampaignEndedReason.CampaignInProgressEndedByUser,
                "campaign.scheduled.ended-by-user" => CampaignEndedReason.CampaignScheduledEndedByUser,
                _ => null,
            };
        }
    }
}