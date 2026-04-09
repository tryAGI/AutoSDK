//HintName: G.Models.GetScoresResponseDataVariant22.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseDataVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetScoresResponseDataVariant2DataTypeJsonConverter))]
        public global::G.GetScoresResponseDataVariant2DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant22" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public GetScoresResponseDataVariant22(
            global::G.GetScoresResponseDataVariant2DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant22" /> class.
        /// </summary>
        public GetScoresResponseDataVariant22()
        {
        }
    }
}