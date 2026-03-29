//HintName: G.Models.Persona.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Persona
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persona_name")]
        public string? PersonaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_replica_id")]
        public string? DefaultReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_mode")]
        public string? PipelineMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        public global::G.PersonaLayers? Layers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails_id")]
        public string? GuardrailsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectives_id")]
        public string? ObjectivesId { get; set; }

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
        /// Initializes a new instance of the <see cref="Persona" /> class.
        /// </summary>
        /// <param name="personaId"></param>
        /// <param name="personaName"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="context"></param>
        /// <param name="defaultReplicaId"></param>
        /// <param name="pipelineMode"></param>
        /// <param name="layers"></param>
        /// <param name="guardrailsId"></param>
        /// <param name="objectivesId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Persona(
            string? personaId,
            string? personaName,
            string? systemPrompt,
            string? context,
            string? defaultReplicaId,
            string? pipelineMode,
            global::G.PersonaLayers? layers,
            string? guardrailsId,
            string? objectivesId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.PersonaId = personaId;
            this.PersonaName = personaName;
            this.SystemPrompt = systemPrompt;
            this.Context = context;
            this.DefaultReplicaId = defaultReplicaId;
            this.PipelineMode = pipelineMode;
            this.Layers = layers;
            this.GuardrailsId = guardrailsId;
            this.ObjectivesId = objectivesId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Persona" /> class.
        /// </summary>
        public Persona()
        {
        }
    }
}