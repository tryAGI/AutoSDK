//HintName: G.Models.SimulationHookCallStarted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookCallStarted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SimulationHookCallStartedOnJsonConverter))]
        public global::G.SimulationHookCallStartedOn On { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimulationHookWebhookAction> Do { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookCallStarted" /> class.
        /// </summary>
        /// <param name="do"></param>
        /// <param name="on"></param>
        public SimulationHookCallStarted(
            global::System.Collections.Generic.IList<global::G.SimulationHookWebhookAction> @do,
            global::G.SimulationHookCallStartedOn on)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookCallStarted" /> class.
        /// </summary>
        public SimulationHookCallStarted()
        {
        }
    }
}