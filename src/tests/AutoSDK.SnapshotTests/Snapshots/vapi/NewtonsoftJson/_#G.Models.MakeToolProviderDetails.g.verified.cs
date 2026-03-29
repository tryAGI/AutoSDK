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
        [global::Newtonsoft.Json.JsonProperty("templateUrl")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setupInstructions")]
        public global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? SetupInstructions { get; set; }

        /// <summary>
        /// The type of tool. "make" for Make tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MakeToolProviderDetailsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarioId")]
        public double? ScenarioId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarioName")]
        public string? ScenarioName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerHookId")]
        public double? TriggerHookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggerHookName")]
        public string? TriggerHookName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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