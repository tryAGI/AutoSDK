//HintName: G.Models.OutputFormatRAWOutputFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputFormatRAWOutputFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public global::G.OutputFormatRAWOutputFormatContainer? Container { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatRAWOutputFormat2" /> class.
        /// </summary>
        /// <param name="container"></param>
        public OutputFormatRAWOutputFormat2(
            global::G.OutputFormatRAWOutputFormatContainer? container)
        {
            this.Container = container;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFormatRAWOutputFormat2" /> class.
        /// </summary>
        public OutputFormatRAWOutputFormat2()
        {
        }
    }
}