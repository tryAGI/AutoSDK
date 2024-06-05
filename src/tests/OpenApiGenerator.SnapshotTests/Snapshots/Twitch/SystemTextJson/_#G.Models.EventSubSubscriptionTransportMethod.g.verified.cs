//HintName: G.Models.EventSubSubscriptionTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// </summary>
    public enum EventSubSubscriptionTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Websocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventSubSubscriptionTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventSubSubscriptionTransportMethod value)
        {
            return value switch
            {
                EventSubSubscriptionTransportMethod.Webhook => "webhook",
                EventSubSubscriptionTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventSubSubscriptionTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => EventSubSubscriptionTransportMethod.Webhook,
                "websocket" => EventSubSubscriptionTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}