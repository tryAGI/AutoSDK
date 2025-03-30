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
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataCollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::G.LiteralJsonSchemaProperty? JsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollectionResultCommonModel" /> class.
        /// </summary>
        /// <param name="dataCollectionId"></param>
        /// <param name="value"></param>
        /// <param name="jsonSchema"></param>
        /// <param name="rationale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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