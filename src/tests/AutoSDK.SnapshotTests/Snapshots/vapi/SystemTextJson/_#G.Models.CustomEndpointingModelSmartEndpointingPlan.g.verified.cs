//HintName: G.Models.CustomEndpointingModelSmartEndpointingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomEndpointingModelSmartEndpointingPlan
    {
        /// <summary>
        /// This is the provider for the smart endpointing plan. Use `custom-endpointing-model` for custom endpointing providers that are not natively supported.<br/>
        /// Example: custom-endpointing-model
        /// </summary>
        /// <example>custom-endpointing-model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomEndpointingModelSmartEndpointingPlanProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomEndpointingModelSmartEndpointingPlanProvider Provider { get; set; }

        /// <summary>
        /// This is where the endpointing request will be sent. If not provided, will be sent to `assistant.server`. If that does not exist either, will be sent to `org.server`.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "call.endpointing.request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "message": "Hello, how are you?",<br/>
        ///         "time": 1234567890,<br/>
        ///         "secondsFromStart": 0<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected:<br/>
        /// {<br/>
        ///   "timeoutSeconds": 0.5<br/>
        /// }<br/>
        /// The timeout is the number of seconds to wait before considering the user's speech as finished. The endpointing timeout is automatically reset each time a new transcript is received (and another `call.endpointing.request` is sent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEndpointingModelSmartEndpointingPlan" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider for the smart endpointing plan. Use `custom-endpointing-model` for custom endpointing providers that are not natively supported.<br/>
        /// Example: custom-endpointing-model
        /// </param>
        /// <param name="server">
        /// This is where the endpointing request will be sent. If not provided, will be sent to `assistant.server`. If that does not exist either, will be sent to `org.server`.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "call.endpointing.request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "message": "Hello, how are you?",<br/>
        ///         "time": 1234567890,<br/>
        ///         "secondsFromStart": 0<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected:<br/>
        /// {<br/>
        ///   "timeoutSeconds": 0.5<br/>
        /// }<br/>
        /// The timeout is the number of seconds to wait before considering the user's speech as finished. The endpointing timeout is automatically reset each time a new transcript is received (and another `call.endpointing.request` is sent).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomEndpointingModelSmartEndpointingPlan(
            global::G.CustomEndpointingModelSmartEndpointingPlanProvider provider,
            global::G.Server? server)
        {
            this.Provider = provider;
            this.Server = server;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEndpointingModelSmartEndpointingPlan" /> class.
        /// </summary>
        public CustomEndpointingModelSmartEndpointingPlan()
        {
        }
    }
}