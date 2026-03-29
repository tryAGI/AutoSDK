//HintName: G.Models.MakeToolMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MakeToolMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarioId")]
        public double? ScenarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerHookId")]
        public double? TriggerHookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeToolMetadata" /> class.
        /// </summary>
        /// <param name="scenarioId"></param>
        /// <param name="triggerHookId"></param>
        public MakeToolMetadata(
            double? scenarioId,
            double? triggerHookId)
        {
            this.ScenarioId = scenarioId;
            this.TriggerHookId = triggerHookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeToolMetadata" /> class.
        /// </summary>
        public MakeToolMetadata()
        {
        }
    }
}