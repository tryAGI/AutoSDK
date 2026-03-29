//HintName: G.Models.Objectives.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Objectives
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectives_id")]
        public string? ObjectivesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective_name")]
        public string? ObjectiveName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective_prompt")]
        public string? ObjectivePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation_mode")]
        public string? ConfirmationMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        public global::System.Collections.Generic.IList<string>? OutputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_conditional_objectives")]
        public global::System.Collections.Generic.IList<global::G.ConditionalObjective>? NextConditionalObjectives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_required_objective")]
        public string? NextRequiredObjective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Objectives" /> class.
        /// </summary>
        /// <param name="objectivesId"></param>
        /// <param name="objectiveName"></param>
        /// <param name="objectivePrompt"></param>
        /// <param name="confirmationMode"></param>
        /// <param name="outputVariables"></param>
        /// <param name="modality"></param>
        /// <param name="nextConditionalObjectives"></param>
        /// <param name="nextRequiredObjective"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Objectives(
            string? objectivesId,
            string? objectiveName,
            string? objectivePrompt,
            string? confirmationMode,
            global::System.Collections.Generic.IList<string>? outputVariables,
            string? modality,
            global::System.Collections.Generic.IList<global::G.ConditionalObjective>? nextConditionalObjectives,
            string? nextRequiredObjective,
            string? callbackUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.ObjectivesId = objectivesId;
            this.ObjectiveName = objectiveName;
            this.ObjectivePrompt = objectivePrompt;
            this.ConfirmationMode = confirmationMode;
            this.OutputVariables = outputVariables;
            this.Modality = modality;
            this.NextConditionalObjectives = nextConditionalObjectives;
            this.NextRequiredObjective = nextRequiredObjective;
            this.CallbackUrl = callbackUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Objectives" /> class.
        /// </summary>
        public Objectives()
        {
        }
    }
}