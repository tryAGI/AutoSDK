//HintName: G.Models.ScoreV1Variant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreV1Variant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        public global::G.ScoreV1Variant1DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreV1Variant12" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public ScoreV1Variant12(
            global::G.ScoreV1Variant1DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreV1Variant12" /> class.
        /// </summary>
        public ScoreV1Variant12()
        {
        }
    }
}