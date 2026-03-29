//HintName: G.Models.GetScoresResponseDataVariant32.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseDataVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        public global::G.GetScoresResponseDataVariant3DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant32" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public GetScoresResponseDataVariant32(
            global::G.GetScoresResponseDataVariant3DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataVariant32" /> class.
        /// </summary>
        public GetScoresResponseDataVariant32()
        {
        }
    }
}