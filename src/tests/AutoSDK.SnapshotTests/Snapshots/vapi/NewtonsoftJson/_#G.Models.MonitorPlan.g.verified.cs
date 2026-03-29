//HintName: G.Models.MonitorPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorPlan
    {
        /// <summary>
        /// This determines whether the assistant's calls allow live listening. Defaults to true.<br/>
        /// Fetch `call.monitor.listenUrl` to get the live listening URL.<br/>
        /// @default true<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("listenEnabled")]
        public bool? ListenEnabled { get; set; }

        /// <summary>
        /// This enables authentication on the `call.monitor.listenUrl`.<br/>
        /// If `listenAuthenticationEnabled` is `true`, the `call.monitor.listenUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("listenAuthenticationEnabled")]
        public bool? ListenAuthenticationEnabled { get; set; }

        /// <summary>
        /// This determines whether the assistant's calls allow live control. Defaults to true.<br/>
        /// Fetch `call.monitor.controlUrl` to get the live control URL.<br/>
        /// To use, send any control message via a POST request to `call.monitor.controlUrl`. Here are the types of controls supported: https://docs.vapi.ai/api-reference/messages/client-inbound-message<br/>
        /// @default true<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("controlEnabled")]
        public bool? ControlEnabled { get; set; }

        /// <summary>
        /// This enables authentication on the `call.monitor.controlUrl`.<br/>
        /// If `controlAuthenticationEnabled` is `true`, the `call.monitor.controlUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("controlAuthenticationEnabled")]
        public bool? ControlAuthenticationEnabled { get; set; }

        /// <summary>
        /// This the set of monitor ids that are attached to the assistant.<br/>
        /// The source of truth for the monitor ids is the assistant_monitor join table.<br/>
        /// This field can be used for transient assistants and to update assistants with new monitor ids.<br/>
        /// @default []<br/>
        /// Example: [123e4567-e89b-12d3-a456-426614174000]
        /// </summary>
        /// <example>[123e4567-e89b-12d3-a456-426614174000]</example>
        [global::Newtonsoft.Json.JsonProperty("monitorIds")]
        public global::System.Collections.Generic.IList<string>? MonitorIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorPlan" /> class.
        /// </summary>
        /// <param name="listenEnabled">
        /// This determines whether the assistant's calls allow live listening. Defaults to true.<br/>
        /// Fetch `call.monitor.listenUrl` to get the live listening URL.<br/>
        /// @default true<br/>
        /// Example: false
        /// </param>
        /// <param name="listenAuthenticationEnabled">
        /// This enables authentication on the `call.monitor.listenUrl`.<br/>
        /// If `listenAuthenticationEnabled` is `true`, the `call.monitor.listenUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="controlEnabled">
        /// This determines whether the assistant's calls allow live control. Defaults to true.<br/>
        /// Fetch `call.monitor.controlUrl` to get the live control URL.<br/>
        /// To use, send any control message via a POST request to `call.monitor.controlUrl`. Here are the types of controls supported: https://docs.vapi.ai/api-reference/messages/client-inbound-message<br/>
        /// @default true<br/>
        /// Example: false
        /// </param>
        /// <param name="controlAuthenticationEnabled">
        /// This enables authentication on the `call.monitor.controlUrl`.<br/>
        /// If `controlAuthenticationEnabled` is `true`, the `call.monitor.controlUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="monitorIds">
        /// This the set of monitor ids that are attached to the assistant.<br/>
        /// The source of truth for the monitor ids is the assistant_monitor join table.<br/>
        /// This field can be used for transient assistants and to update assistants with new monitor ids.<br/>
        /// @default []<br/>
        /// Example: [123e4567-e89b-12d3-a456-426614174000]
        /// </param>
        public MonitorPlan(
            bool? listenEnabled,
            bool? listenAuthenticationEnabled,
            bool? controlEnabled,
            bool? controlAuthenticationEnabled,
            global::System.Collections.Generic.IList<string>? monitorIds)
        {
            this.ListenEnabled = listenEnabled;
            this.ListenAuthenticationEnabled = listenAuthenticationEnabled;
            this.ControlEnabled = controlEnabled;
            this.ControlAuthenticationEnabled = controlAuthenticationEnabled;
            this.MonitorIds = monitorIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorPlan" /> class.
        /// </summary>
        public MonitorPlan()
        {
        }
    }
}