//HintName: G.Models.CreateObjectivesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateObjectivesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objective_name")]
        public string? ObjectiveName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objective_prompt")]
        public string? ObjectivePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confirmation_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateObjectivesRequestConfirmationModeJsonConverter))]
        public global::G.CreateObjectivesRequestConfirmationMode? ConfirmationMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_variables")]
        public global::System.Collections.Generic.IList<string>? OutputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_conditional_objectives")]
        public global::System.Collections.Generic.IList<global::G.ConditionalObjective>? NextConditionalObjectives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_required_objective")]
        public string? NextRequiredObjective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectivesRequest" /> class.
        /// </summary>
        /// <param name="objectiveName"></param>
        /// <param name="objectivePrompt"></param>
        /// <param name="confirmationMode"></param>
        /// <param name="outputVariables"></param>
        /// <param name="modality"></param>
        /// <param name="nextConditionalObjectives"></param>
        /// <param name="nextRequiredObjective"></param>
        /// <param name="callbackUrl"></param>
        public CreateObjectivesRequest(
            string? objectiveName,
            string? objectivePrompt,
            global::G.CreateObjectivesRequestConfirmationMode? confirmationMode,
            global::System.Collections.Generic.IList<string>? outputVariables,
            string? modality,
            global::System.Collections.Generic.IList<global::G.ConditionalObjective>? nextConditionalObjectives,
            string? nextRequiredObjective,
            string? callbackUrl)
        {
            this.ObjectiveName = objectiveName;
            this.ObjectivePrompt = objectivePrompt;
            this.ConfirmationMode = confirmationMode;
            this.OutputVariables = outputVariables;
            this.Modality = modality;
            this.NextConditionalObjectives = nextConditionalObjectives;
            this.NextRequiredObjective = nextRequiredObjective;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectivesRequest" /> class.
        /// </summary>
        public CreateObjectivesRequest()
        {
        }
    }
}