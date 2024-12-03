//HintName: G.Models.DatasetShareSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetShareSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DatasetShareSchema" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareToken"></param>
        public DatasetShareSchema(
            global::System.Guid datasetId,
            global::System.Guid shareToken)
        {
            this.DatasetId = datasetId;
            this.ShareToken = shareToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetShareSchema" /> class.
        /// </summary>
        public DatasetShareSchema()
        {
        }
    }
}