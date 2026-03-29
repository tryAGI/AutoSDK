//HintName: G.Models.UpdateCampaignDTOStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the campaign.<br/>
    /// Can only be updated to 'ended' if you want to end the campaign.<br/>
    /// When set to 'ended', it will delete all scheduled calls. Calls in progress will be allowed to complete.
    /// </summary>
    public enum UpdateCampaignDTOStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCampaignDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCampaignDTOStatus value)
        {
            return value switch
            {
                UpdateCampaignDTOStatus.Ended => "ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCampaignDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "ended" => UpdateCampaignDTOStatus.Ended,
                _ => null,
            };
        }
    }
}