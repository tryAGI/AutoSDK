//HintName: G.Models.EvaluationStatusRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.EvaluationStatusNotFound, global::G.EvaluationStatusRunning, global::G.EvaluationStatusFailed, global::G.EvaluationStatusComplete> Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusRes" /> class.
        /// </summary>
        /// <param name="status"></param>
        public EvaluationStatusRes(
            global::G.AnyOf<global::G.EvaluationStatusNotFound, global::G.EvaluationStatusRunning, global::G.EvaluationStatusFailed, global::G.EvaluationStatusComplete> status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusRes" /> class.
        /// </summary>
        public EvaluationStatusRes()
        {
        }
    }
}