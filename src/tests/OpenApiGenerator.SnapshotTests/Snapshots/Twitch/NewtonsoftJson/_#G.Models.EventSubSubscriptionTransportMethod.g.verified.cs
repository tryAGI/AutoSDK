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
    [global::System.Runtime.Serialization.DataContract]
    public enum EventSubSubscriptionTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket")]
        Websocket,
    }

    public static class EventSubSubscriptionTransportMethodExtensions
    {
        public static string ToValueString(this EventSubSubscriptionTransportMethod value)
        {
            return value switch
            {
                EventSubSubscriptionTransportMethod.Webhook => "webhook",
                EventSubSubscriptionTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EventSubSubscriptionTransportMethod ToEnum(string value)
        {
            return value switch
            {
                "webhook" => EventSubSubscriptionTransportMethod.Webhook,
                "websocket" => EventSubSubscriptionTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EventSubSubscriptionTransportMethod ToEnum(int value)
        {
            return value switch
            {
                0 => EventSubSubscriptionTransportMethod.Webhook,
                1 => EventSubSubscriptionTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}