//HintName: G.Models.WebhookDependabotAlertReintroducedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDependabotAlertReintroducedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reintroduced")]
        Reintroduced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertReintroducedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertReintroducedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertReintroducedAction.Reintroduced => "reintroduced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertReintroducedAction? ToEnum(string value)
        {
            return value switch
            {
                "reintroduced" => WebhookDependabotAlertReintroducedAction.Reintroduced,
                _ => null,
            };
        }
    }
}