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
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Meta { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_hypotheses", Required = global::Newtonsoft.Json.Required.Always)]
        public double NumHypotheses { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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