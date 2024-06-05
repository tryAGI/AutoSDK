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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEventSubSubscriptionBodyTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventSubSubscriptionBodyTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => CreateEventSubSubscriptionBodyTransportMethod.Webhook,
                "websocket" => CreateEventSubSubscriptionBodyTransportMethod.Websocket,
                "conduit" => CreateEventSubSubscriptionBodyTransportMethod.Conduit,
                _ => null,
            };
        }
    }
}