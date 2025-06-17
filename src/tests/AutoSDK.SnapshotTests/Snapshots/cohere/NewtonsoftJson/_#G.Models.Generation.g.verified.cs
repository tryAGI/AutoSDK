//HintName: G.Models.Generation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// List of generated results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SingleGeneration> Generations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Prompt used for generations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="generations">
        /// List of generated results
        /// </param>
        /// <param name="id"></param>
        /// <param name="meta"></param>
        /// <param name="prompt">
        /// Prompt used for generations.
        /// </param>
        public Generation(
            global::System.Collections.Generic.IList<global::G.SingleGeneration> generations,
            string id,
            global::G.ApiMeta? meta,
            string? prompt)
        {
            this.Generations = generations ?? throw new global::System.ArgumentNullException(nameof(generations));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}