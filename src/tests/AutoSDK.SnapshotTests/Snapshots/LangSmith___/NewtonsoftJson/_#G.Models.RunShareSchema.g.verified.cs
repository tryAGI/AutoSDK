//HintName: G.Models.RunShareSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunShareSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_token", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ShareToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShareSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="shareToken"></param>
        public RunShareSchema(
            global::System.Guid runId,
            global::System.Guid shareToken)
        {
            this.RunId = runId;
            this.ShareToken = shareToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShareSchema" /> class.
        /// </summary>
        public RunShareSchema()
        {
        }
    }
}