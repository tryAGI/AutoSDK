//HintName: G.Models.GenerateStreamEndVariant2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamEndVariant2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generations")]
        public global::System.Collections.Generic.IList<global::G.SingleGenerationInStream>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2Response" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prompt"></param>
        /// <param name="generations"></param>
        public GenerateStreamEndVariant2Response(
            string id,
            string? prompt,
            global::System.Collections.Generic.IList<global::G.SingleGenerationInStream>? generations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Prompt = prompt;
            this.Generations = generations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2Response" /> class.
        /// </summary>
        public GenerateStreamEndVariant2Response()
        {
        }
    }
}