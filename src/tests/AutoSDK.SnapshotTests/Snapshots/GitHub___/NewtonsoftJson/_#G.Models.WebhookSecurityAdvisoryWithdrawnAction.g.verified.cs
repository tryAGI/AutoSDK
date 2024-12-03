//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookSecurityAdvisoryWithdrawnAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="withdrawn")]
        Withdrawn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecurityAdvisoryWithdrawnActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecurityAdvisoryWithdrawnAction value)
        {
            return value switch
            {
                WebhookSecurityAdvisoryWithdrawnAction.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecurityAdvisoryWithdrawnAction? ToEnum(string value)
        {
            return value switch
            {
                "withdrawn" => WebhookSecurityAdvisoryWithdrawnAction.Withdrawn,
                _ => null,
            };
        }
    }
}