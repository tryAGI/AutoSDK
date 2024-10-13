//HintName: G.Models.ReposUpdateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateWebhookRequest
    {
        /// <summary>
        /// Configuration object of the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.WebhookConfig? Config { get; set; }

        /// <summary>
        /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.<br/>
        /// Default Value: [push]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Determines a list of events to be added to the list of events that the Hook triggers for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_events")]
        public global::System.Collections.Generic.IList<string>? AddEvents { get; set; }

        /// <summary>
        /// Determines a list of events to be removed from the list of events that the Hook triggers for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_events")]
        public global::System.Collections.Generic.IList<string>? RemoveEvents { get; set; }

        /// <summary>
        /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposUpdateWebhookRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposUpdateWebhookRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}