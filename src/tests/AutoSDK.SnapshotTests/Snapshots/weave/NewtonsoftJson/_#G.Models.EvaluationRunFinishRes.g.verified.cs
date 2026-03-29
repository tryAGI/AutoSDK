//HintName: G.Models.EvaluationRunFinishRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunFinishRes
    {
        /// <summary>
        /// Whether the evaluation run was finished successfully
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunFinishRes" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the evaluation run was finished successfully
        /// </param>
        public EvaluationRunFinishRes(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunFinishRes" /> class.
        /// </summary>
        public EvaluationRunFinishRes()
        {
        }
    }
}