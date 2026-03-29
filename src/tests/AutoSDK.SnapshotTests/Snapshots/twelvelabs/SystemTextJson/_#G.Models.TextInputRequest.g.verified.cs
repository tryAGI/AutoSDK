//HintName: G.Models.TextInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `text`.
    /// </summary>
    public sealed partial class TextInputRequest
    {
        /// <summary>
        /// The text for which you wish to create an embedding. The maximul length is 500 tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputRequest" /> class.
        /// </summary>
        /// <param name="inputText">
        /// The text for which you wish to create an embedding. The maximul length is 500 tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextInputRequest(
            string inputText)
        {
            this.InputText = inputText ?? throw new global::System.ArgumentNullException(nameof(inputText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputRequest" /> class.
        /// </summary>
        public TextInputRequest()
        {
        }
    }
}