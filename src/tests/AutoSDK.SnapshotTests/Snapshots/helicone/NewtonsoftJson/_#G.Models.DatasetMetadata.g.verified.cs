//HintName: G.Models.DatasetMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersionId")]
        public string? PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputRecordsIds")]
        public global::System.Collections.Generic.IList<string>? InputRecordsIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetMetadata" /> class.
        /// </summary>
        /// <param name="promptVersionId"></param>
        /// <param name="inputRecordsIds"></param>
        public DatasetMetadata(
            string? promptVersionId,
            global::System.Collections.Generic.IList<string>? inputRecordsIds)
        {
            this.PromptVersionId = promptVersionId;
            this.InputRecordsIds = inputRecordsIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetMetadata" /> class.
        /// </summary>
        public DatasetMetadata()
        {
        }
    }
}