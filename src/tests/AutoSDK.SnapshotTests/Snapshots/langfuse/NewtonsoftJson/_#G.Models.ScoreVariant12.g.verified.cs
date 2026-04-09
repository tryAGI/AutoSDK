//HintName: G.Models.ScoreVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScoreVariant1DataTypeJsonConverter))]
        public global::G.ScoreVariant1DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreVariant12" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public ScoreVariant12(
            global::G.ScoreVariant1DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreVariant12" /> class.
        /// </summary>
        public ScoreVariant12()
        {
        }
    }
}