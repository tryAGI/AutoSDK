//HintName: G.Models.CampaignControllerFindAllStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignControllerFindAllStatus
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
    public static class CampaignControllerFindAllStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllStatus value)
        {
            return value switch
            {
                CampaignControllerFindAllStatus.Ended => "ended",
                CampaignControllerFindAllStatus.InProgress => "in-progress",
                CampaignControllerFindAllStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => CampaignControllerFindAllStatus.Ended,
                "in-progress" => CampaignControllerFindAllStatus.InProgress,
                "scheduled" => CampaignControllerFindAllStatus.Scheduled,
                _ => null,
            };
        }
    }
}