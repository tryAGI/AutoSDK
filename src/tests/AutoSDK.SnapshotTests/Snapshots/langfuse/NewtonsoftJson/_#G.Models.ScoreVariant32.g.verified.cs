//HintName: G.Models.ScoreVariant32.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScoreVariant3DataTypeJsonConverter))]
        public global::G.ScoreVariant3DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreVariant32" /> class.
        /// </summary>
        /// <param name="dataType"></param>
        public ScoreVariant32(
            global::G.ScoreVariant3DataType? dataType)
        {
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreVariant32" /> class.
        /// </summary>
        public ScoreVariant32()
        {
        }
    }
}