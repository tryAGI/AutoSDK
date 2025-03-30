//HintName: G.Models.DataCollectionResultCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataCollectionResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_collection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataCollectionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public global::G.LiteralJsonSchemaProperty? JsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rationale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Rationale { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollectionResultCommonModel" /> class.
        /// </summary>
        /// <param name="dataCollectionId"></param>
        /// <param name="value"></param>
        /// <param name="jsonSchema"></param>
        /// <param name="rationale"></param>
        public DataCollectionResultCommonModel(
            string dataCollectionId,
            string rationale,
            object? value,
            global::G.LiteralJsonSchemaProperty? jsonSchema)
        {
            this.DataCollectionId = dataCollectionId ?? throw new global::System.ArgumentNullException(nameof(dataCollectionId));
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.Value = value;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollectionResultCommonModel" /> class.
        /// </summary>
        public DataCollectionResultCommonModel()
        {
        }
    }
}