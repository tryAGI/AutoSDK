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
        [global::Newtonsoft.Json.JsonProperty("_type")]
        public global::G.HeliconeEventVectorDBType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HeliconeEventVectorDBOperation Operation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector")]
        public global::System.Collections.Generic.IList<double>? Vector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.HeliconeEventVectorDBFilter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("databaseName")]
        public string? DatabaseName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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