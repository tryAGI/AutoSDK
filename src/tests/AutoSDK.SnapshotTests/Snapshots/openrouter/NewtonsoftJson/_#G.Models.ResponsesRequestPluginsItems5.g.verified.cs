//HintName: G.Models.ResponsesRequestPluginsItems5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItems5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.ResponsesRequestPluginsItemsOneOf5Id Id { get; set; }

        /// <summary>
        /// Set to false to disable the context-compression plugin for this request. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The compression engine to use. Defaults to "middle-out".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        public global::G.ContextCompressionEngine? Engine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems5" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the context-compression plugin for this request. Defaults to true.
        /// </param>
        /// <param name="engine">
        /// The compression engine to use. Defaults to "middle-out".
        /// </param>
        public ResponsesRequestPluginsItems5(
            global::G.ResponsesRequestPluginsItemsOneOf5Id id,
            bool? enabled,
            global::G.ContextCompressionEngine? engine)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Engine = engine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems5" /> class.
        /// </summary>
        public ResponsesRequestPluginsItems5()
        {
        }
    }
}