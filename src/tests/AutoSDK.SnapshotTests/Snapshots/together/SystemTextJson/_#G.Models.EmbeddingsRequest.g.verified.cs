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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = "Our solar system orbits the Milky Way galaxy at about 515,000 mph";

        /// <summary>
        /// The name of the embedding model to use.<br/>
        /// Default Value: togethercomputer/m2-bert-80M-8k-retrieval<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </summary>
        /// <default>"togethercomputer/m2-bert-80M-8k-retrieval"</default>
        /// <example>togethercomputer/m2-bert-80M-8k-retrieval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "togethercomputer/m2-bert-80M-8k-retrieval";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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