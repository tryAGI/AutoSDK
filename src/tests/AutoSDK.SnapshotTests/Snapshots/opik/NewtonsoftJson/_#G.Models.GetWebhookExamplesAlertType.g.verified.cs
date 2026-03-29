//HintName: G.Models.GetWebhookExamplesAlertType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetWebhookExamplesAlertType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="general")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pagerduty")]
        Pagerduty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack")]
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWebhookExamplesAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWebhookExamplesAlertType value)
        {
            return value switch
            {
                GetWebhookExamplesAlertType.General => "general",
                GetWebhookExamplesAlertType.Pagerduty => "pagerduty",
                GetWebhookExamplesAlertType.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWebhookExamplesAlertType? ToEnum(string value)
        {
            return value switch
            {
                "general" => GetWebhookExamplesAlertType.General,
                "pagerduty" => GetWebhookExamplesAlertType.Pagerduty,
                "slack" => GetWebhookExamplesAlertType.Slack,
                _ => null,
            };
        }
    }
}