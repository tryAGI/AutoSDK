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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::G.SingleGenerationInStream>? Generations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2Response" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="prompt"></param>
        /// <param name="generations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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