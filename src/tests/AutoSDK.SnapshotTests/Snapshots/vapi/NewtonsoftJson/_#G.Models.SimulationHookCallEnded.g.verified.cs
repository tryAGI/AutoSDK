//HintName: G.Models.SimulationHookCallEnded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookCallEnded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on")]
        public global::G.SimulationHookCallEndedOn On { get; set; }

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
        /// Initializes a new instance of the <see cref="SimulationHookCallEnded" /> class.
        /// </summary>
        /// <param name="do"></param>
        /// <param name="on"></param>
        public SimulationHookCallEnded(
            global::System.Collections.Generic.IList<global::G.SimulationHookWebhookAction> @do,
            global::G.SimulationHookCallEndedOn on)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookCallEnded" /> class.
        /// </summary>
        public SimulationHookCallEnded()
        {
        }
    }
}