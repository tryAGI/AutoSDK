//HintName: G.Models.CreateEventSubSubscriptionBodyTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// * conduit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEventSubSubscriptionBodyTransportMethod
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conduit")]
        Conduit,
    }

    public static class CreateEventSubSubscriptionBodyTransportMethodExtensions
    {
        public static string ToValueString(this CreateEventSubSubscriptionBodyTransportMethod value)
        {
            return value switch
            {
                CreateEventSubSubscriptionBodyTransportMethod.Webhook => "webhook",
                CreateEventSubSubscriptionBodyTransportMethod.Websocket => "websocket",
                CreateEventSubSubscriptionBodyTransportMethod.Conduit => "conduit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEventSubSubscriptionBodyTransportMethod ToEnum(string value)
        {
            return value switch
            {
                "webhook" => CreateEventSubSubscriptionBodyTransportMethod.Webhook,
                "websocket" => CreateEventSubSubscriptionBodyTransportMethod.Websocket,
                "conduit" => CreateEventSubSubscriptionBodyTransportMethod.Conduit,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateEventSubSubscriptionBodyTransportMethod ToEnum(int value)
        {
            return value switch
            {
                0 => CreateEventSubSubscriptionBodyTransportMethod.Webhook,
                1 => CreateEventSubSubscriptionBodyTransportMethod.Websocket,
                2 => CreateEventSubSubscriptionBodyTransportMethod.Conduit,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}