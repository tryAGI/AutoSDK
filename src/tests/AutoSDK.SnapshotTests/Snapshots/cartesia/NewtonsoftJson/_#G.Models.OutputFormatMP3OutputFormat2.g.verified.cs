//HintName: G.Models.OutputFormatMP3OutputFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputFormatMP3OutputFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputFormatMP3OutputFormatContainerJsonConverter))]
        public global::G.OutputFormatMP3OutputFormatContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatMP3OutputFormat2" /> class.
        /// </summary>
        /// <param name="container"></param>
        public OutputFormatMP3OutputFormat2(
            global::G.OutputFormatMP3OutputFormatContainer? container)
        {
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatMP3OutputFormat2" /> class.
        /// </summary>
        public OutputFormatMP3OutputFormat2()
        {
        }
    }
}