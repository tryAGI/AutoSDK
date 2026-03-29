//HintName: G.Models.ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecordStringAny Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_hypotheses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumHypotheses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem" /> class.
        /// </summary>
        /// <param name="meta">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="dataset"></param>
        /// <param name="numHypotheses"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem(
            global::G.RecordStringAny meta,
            string dataset,
            double numHypotheses,
            string createdAt,
            string id)
        {
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.NumHypotheses = numHypotheses;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessIdStringCreatedAtStringNumHypothesesNumberDatasetStringMetaRecordStringAnyArrayDataItem()
        {
        }
    }
}