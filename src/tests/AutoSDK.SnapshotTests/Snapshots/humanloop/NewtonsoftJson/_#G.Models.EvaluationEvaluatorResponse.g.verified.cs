//HintName: G.Models.EvaluationEvaluatorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationEvaluatorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorId")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorVersionId")]
        public string? EvaluatorVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationEvaluatorResponse" /> class.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="evaluatorVersionId"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public EvaluationEvaluatorResponse(
            string? evaluatorId,
            string? evaluatorVersionId,
            string? name,
            string? path)
        {
            this.EvaluatorId = evaluatorId;
            this.EvaluatorVersionId = evaluatorVersionId;
            this.Name = name;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationEvaluatorResponse" /> class.
        /// </summary>
        public EvaluationEvaluatorResponse()
        {
        }
    }
}