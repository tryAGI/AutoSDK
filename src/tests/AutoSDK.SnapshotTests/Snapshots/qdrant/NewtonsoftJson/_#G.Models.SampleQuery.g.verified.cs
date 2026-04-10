//HintName: G.Models.SampleQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SampleJsonConverter))]
        public global::G.Sample Sample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleQuery" /> class.
        /// </summary>
        /// <param name="sample"></param>
        public SampleQuery(
            global::G.Sample sample)
        {
            this.Sample = sample;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleQuery" /> class.
        /// </summary>
        public SampleQuery()
        {
        }
    }
}