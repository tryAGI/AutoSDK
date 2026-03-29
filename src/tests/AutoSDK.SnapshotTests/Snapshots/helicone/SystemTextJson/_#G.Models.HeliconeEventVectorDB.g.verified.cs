//HintName: G.Models.HeliconeEventVectorDB.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeEventVectorDB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HeliconeEventVectorDBTypeJsonConverter))]
        public global::G.HeliconeEventVectorDBType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HeliconeEventVectorDBOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HeliconeEventVectorDBOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::System.Collections.Generic.IList<double>? Vector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.HeliconeEventVectorDBFilter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databaseName")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventVectorDB" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="vector"></param>
        /// <param name="topK"></param>
        /// <param name="filter"></param>
        /// <param name="databaseName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeliconeEventVectorDB(
            global::G.HeliconeEventVectorDBOperation operation,
            global::G.HeliconeEventVectorDBType type,
            string? text,
            global::System.Collections.Generic.IList<double>? vector,
            double? topK,
            global::G.HeliconeEventVectorDBFilter? filter,
            string? databaseName)
        {
            this.Type = type;
            this.Operation = operation;
            this.Text = text;
            this.Vector = vector;
            this.TopK = topK;
            this.Filter = filter;
            this.DatabaseName = databaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeEventVectorDB" /> class.
        /// </summary>
        public HeliconeEventVectorDB()
        {
        }
    }
}