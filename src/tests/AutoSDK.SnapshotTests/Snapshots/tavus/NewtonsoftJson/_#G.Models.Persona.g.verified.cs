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
        [global::Newtonsoft.Json.JsonProperty("persona_id")]
        public string? PersonaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persona_name")]
        public string? PersonaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_replica_id")]
        public string? DefaultReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_mode")]
        public string? PipelineMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("layers")]
        public global::G.PersonaLayers? Layers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrails_id")]
        public string? GuardrailsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectives_id")]
        public string? ObjectivesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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