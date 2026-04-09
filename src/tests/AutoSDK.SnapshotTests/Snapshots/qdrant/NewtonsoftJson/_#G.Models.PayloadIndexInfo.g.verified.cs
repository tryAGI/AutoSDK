//HintName: G.Models.PayloadIndexInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Display payload field type &amp; index information
    /// </summary>
    public sealed partial class PayloadIndexInfo
    {
        /// <summary>
        /// All possible names of payload types
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PayloadSchemaTypeJsonConverter))]
        public global::G.PayloadSchemaType DataType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public global::G.PayloadSchemaParams? Params { get; set; }

        /// <summary>
        /// Number of points indexed with this index
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points", Required = global::Newtonsoft.Json.Required.Always)]
        public int Points { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexInfo" /> class.
        /// </summary>
        /// <param name="dataType">
        /// All possible names of payload types
        /// </param>
        /// <param name="points">
        /// Number of points indexed with this index
        /// </param>
        /// <param name="params"></param>
        public PayloadIndexInfo(
            global::G.PayloadSchemaType dataType,
            int points,
            global::G.PayloadSchemaParams? @params)
        {
            this.DataType = dataType;
            this.Params = @params;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexInfo" /> class.
        /// </summary>
        public PayloadIndexInfo()
        {
        }
    }
}