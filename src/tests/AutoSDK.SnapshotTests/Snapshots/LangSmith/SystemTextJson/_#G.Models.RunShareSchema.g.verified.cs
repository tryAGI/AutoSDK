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
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ShareToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShareSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="shareToken"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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