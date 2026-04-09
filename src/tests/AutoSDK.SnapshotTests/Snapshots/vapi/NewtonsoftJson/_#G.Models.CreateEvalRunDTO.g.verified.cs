//HintName: G.Models.CreateEvalRunDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalRunDTO
    {
        /// <summary>
        /// This is the transient eval that will be run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval")]
        public global::G.CreateEvalDTO? Eval { get; set; }

        /// <summary>
        /// This is the target that will be run against the eval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad> Target { get; set; } = default!;

        /// <summary>
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </summary>
        /// <example>eval</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateEvalRunDTOTypeJsonConverter))]
        public global::G.CreateEvalRunDTOType Type { get; set; }

        /// <summary>
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::Newtonsoft.Json.JsonProperty("evalId")]
        public string? EvalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunDTO" /> class.
        /// </summary>
        /// <param name="target">
        /// This is the target that will be run against the eval
        /// </param>
        /// <param name="eval">
        /// This is the transient eval that will be run
        /// </param>
        /// <param name="type">
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </param>
        /// <param name="evalId">
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        public CreateEvalRunDTO(
            global::G.OneOf<global::G.EvalRunTargetAssistant, global::G.EvalRunTargetSquad> target,
            global::G.CreateEvalDTO? eval,
            global::G.CreateEvalRunDTOType type,
            string? evalId)
        {
            this.Eval = eval;
            this.Target = target;
            this.Type = type;
            this.EvalId = evalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunDTO" /> class.
        /// </summary>
        public CreateEvalRunDTO()
        {
        }
    }
}