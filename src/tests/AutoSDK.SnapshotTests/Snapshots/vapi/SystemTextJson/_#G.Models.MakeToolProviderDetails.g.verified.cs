//HintName: G.Models.MakeToolProviderDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MakeToolProviderDetails
    {
        /// <summary>
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateUrl")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupInstructions")]
        public global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? SetupInstructions { get; set; }

        /// <summary>
        /// The type of tool. "make" for Make tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MakeToolProviderDetailsTypeJsonConverter))]
        public global::G.MakeToolProviderDetailsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        public double? ScenarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioName")]
        public string? ScenarioName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerHookId")]
        public double? TriggerHookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerHookName")]
        public string? TriggerHookName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeToolProviderDetails" /> class.
        /// </summary>
        /// <param name="templateUrl">
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </param>
        /// <param name="setupInstructions"></param>
        /// <param name="type">
        /// The type of tool. "make" for Make tool.
        /// </param>
        /// <param name="scenarioId"></param>
        /// <param name="scenarioName"></param>
        /// <param name="triggerHookId"></param>
        /// <param name="triggerHookName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MakeToolProviderDetails(
            string? templateUrl,
            global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? setupInstructions,
            global::G.MakeToolProviderDetailsType type,
            double? scenarioId,
            string? scenarioName,
            double? triggerHookId,
            string? triggerHookName)
        {
            this.TemplateUrl = templateUrl;
            this.SetupInstructions = setupInstructions;
            this.Type = type;
            this.ScenarioId = scenarioId;
            this.ScenarioName = scenarioName;
            this.TriggerHookId = triggerHookId;
            this.TriggerHookName = triggerHookName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeToolProviderDetails" /> class.
        /// </summary>
        public MakeToolProviderDetails()
        {
        }
    }
}