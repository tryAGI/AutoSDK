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
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        public double? ScenarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerHookId")]
        public double? TriggerHookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeToolMetadata" /> class.
        /// </summary>
        /// <param name="scenarioId"></param>
        /// <param name="triggerHookId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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