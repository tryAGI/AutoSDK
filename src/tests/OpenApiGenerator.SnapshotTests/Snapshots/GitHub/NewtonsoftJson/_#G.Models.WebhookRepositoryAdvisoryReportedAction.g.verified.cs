//HintName: G.Models.WebhookRepositoryAdvisoryReportedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookRepositoryAdvisoryReportedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reported")]
        Reported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryAdvisoryReportedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryAdvisoryReportedAction value)
        {
            return value switch
            {
                WebhookRepositoryAdvisoryReportedAction.Reported => "reported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryAdvisoryReportedAction ToEnum(string value)
        {
            return value switch
            {
                "reported" => WebhookRepositoryAdvisoryReportedAction.Reported,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}