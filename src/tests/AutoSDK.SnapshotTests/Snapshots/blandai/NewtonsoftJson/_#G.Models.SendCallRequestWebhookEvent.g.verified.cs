//HintName: G.Models.SendCallRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendCallRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call")]
        Call,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citations")]
        Citations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_data")]
        DynamicData,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency")]
        Latency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queue")]
        Queue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendCallRequestWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendCallRequestWebhookEvent value)
        {
            return value switch
            {
                SendCallRequestWebhookEvent.Call => "call",
                SendCallRequestWebhookEvent.Citations => "citations",
                SendCallRequestWebhookEvent.DynamicData => "dynamic_data",
                SendCallRequestWebhookEvent.Latency => "latency",
                SendCallRequestWebhookEvent.Queue => "queue",
                SendCallRequestWebhookEvent.Tool => "tool",
                SendCallRequestWebhookEvent.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendCallRequestWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "call" => SendCallRequestWebhookEvent.Call,
                "citations" => SendCallRequestWebhookEvent.Citations,
                "dynamic_data" => SendCallRequestWebhookEvent.DynamicData,
                "latency" => SendCallRequestWebhookEvent.Latency,
                "queue" => SendCallRequestWebhookEvent.Queue,
                "tool" => SendCallRequestWebhookEvent.Tool,
                "webhook" => SendCallRequestWebhookEvent.Webhook,
                _ => null,
            };
        }
    }
}