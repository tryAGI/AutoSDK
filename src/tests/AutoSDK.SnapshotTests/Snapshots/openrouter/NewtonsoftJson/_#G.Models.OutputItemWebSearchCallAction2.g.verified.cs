//HintName: G.Models.OutputItemWebSearchCallAction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemWebSearchCallAction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OutputItemWebSearchCallActionOneOf2TypeJsonConverter))]
        public global::G.OutputItemWebSearchCallActionOneOf2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallAction2" /> class.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="url"></param>
        /// <param name="type"></param>
        public OutputItemWebSearchCallAction2(
            string pattern,
            string url,
            global::G.OutputItemWebSearchCallActionOneOf2Type type)
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemWebSearchCallAction2" /> class.
        /// </summary>
        public OutputItemWebSearchCallAction2()
        {
        }
    }
}