//HintName: G.Models.GetScoresResponseDataVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseDataVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetScoresResponseDataVariant1DataTypeJsonConverter))]
        public global::G.GetScoresResponseDataVariant1DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant12" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public GetScoresResponseDataVariant12(
            global::G.GetScoresResponseDataVariant1DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant12" /> class.
        /// </summary>
        public GetScoresResponseDataVariant12()
        {
        }
    }
}