//HintName: G.Models.DeleteEvalRunResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteEvalRunResponse
    {
        /// <summary>
        /// Example: eval.run.deleted
        /// </summary>
        /// <example>eval.run.deleted</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Example: evalrun_677469f564d48190807532a852da3afb
        /// </summary>
        /// <example>evalrun_677469f564d48190807532a852da3afb</example>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalRunResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: eval.run.deleted
        /// </param>
        /// <param name="deleted">
        /// Example: true
        /// </param>
        /// <param name="runId">
        /// Example: evalrun_677469f564d48190807532a852da3afb
        /// </param>
        public DeleteEvalRunResponse(
            string? @object,
            bool? deleted,
            string? runId)
        {
            this.Object = @object;
            this.Deleted = deleted;
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvalRunResponse" /> class.
        /// </summary>
        public DeleteEvalRunResponse()
        {
        }
    }
}