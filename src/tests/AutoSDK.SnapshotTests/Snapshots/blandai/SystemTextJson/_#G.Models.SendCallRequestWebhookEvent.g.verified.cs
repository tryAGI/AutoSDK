//HintName: G.Models.SendCallRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SendCallRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Call,
        /// <summary>
        /// 
        /// </summary>
        Citations,
        /// <summary>
        /// 
        /// </summary>
        DynamicData,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Queue,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
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