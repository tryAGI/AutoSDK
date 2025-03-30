//HintName: G.Models.AgentMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentMetadataResponseModel
    {
        /// <summary>
        /// The creation time of the agent in unix seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="createdAtUnixSecs">
        /// The creation time of the agent in unix seconds
        /// </param>
        public AgentMetadataResponseModel(
            int createdAtUnixSecs)
        {
            this.CreatedAtUnixSecs = createdAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataResponseModel" /> class.
        /// </summary>
        public AgentMetadataResponseModel()
        {
        }
    }
}