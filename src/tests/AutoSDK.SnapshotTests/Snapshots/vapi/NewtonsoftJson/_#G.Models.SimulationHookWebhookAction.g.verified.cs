//HintName: G.Models.SimulationHookWebhookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookWebhookAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SimulationHookWebhookActionTypeJsonConverter))]
        public global::G.SimulationHookWebhookActionType Type { get; set; }

        /// <summary>
        /// Optional server override for this hook action.<br/>
        /// If omitted, runtime defaults may apply (e.g. org server).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// Optional payload include controls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::G.SimulationHookInclude? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookWebhookAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="server">
        /// Optional server override for this hook action.<br/>
        /// If omitted, runtime defaults may apply (e.g. org server).
        /// </param>
        /// <param name="include">
        /// Optional payload include controls.
        /// </param>
        public SimulationHookWebhookAction(
            global::G.SimulationHookWebhookActionType type,
            global::G.Server? server,
            global::G.SimulationHookInclude? include)
        {
            this.Type = type;
            this.Server = server;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookWebhookAction" /> class.
        /// </summary>
        public SimulationHookWebhookAction()
        {
        }
    }
}