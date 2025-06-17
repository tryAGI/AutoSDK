//HintName: G.Models.TokenizeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenizeRequest
    {
        /// <summary>
        /// The input will be tokenized by the tokenizer that is used by this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The string to be tokenized, the minimum text length is 1 character, and the maximum text length is 65536 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The input will be tokenized by the tokenizer that is used by this model.
        /// </param>
        /// <param name="text">
        /// The string to be tokenized, the minimum text length is 1 character, and the maximum text length is 65536 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenizeRequest(
            string model,
            string text)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest" /> class.
        /// </summary>
        public TokenizeRequest()
        {
        }
    }
}