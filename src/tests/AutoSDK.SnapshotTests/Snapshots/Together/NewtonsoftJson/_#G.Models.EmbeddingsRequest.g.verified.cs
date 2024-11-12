//HintName: G.Models.EmbeddingsRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsRequest
    {
        /// <summary>
        /// Default Value: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </summary>
        /// <default>"Our solar system orbits the Milky Way galaxy at about 515,000 mph"</default>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = default!;

        /// <summary>
        /// The name of the embedding model to use.<br/>
        /// Default Value: togethercomputer/m2-bert-80M-8k-retrieval<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </summary>
        /// <default>"togethercomputer/m2-bert-80M-8k-retrieval"</default>
        /// <example>togethercomputer/m2-bert-80M-8k-retrieval</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Default Value: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </param>
        /// <param name="model">
        /// The name of the embedding model to use.<br/>
        /// Default Value: togethercomputer/m2-bert-80M-8k-retrieval<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </param>
        public EmbeddingsRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            string model)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        public EmbeddingsRequest()
        {
        }
    }
}