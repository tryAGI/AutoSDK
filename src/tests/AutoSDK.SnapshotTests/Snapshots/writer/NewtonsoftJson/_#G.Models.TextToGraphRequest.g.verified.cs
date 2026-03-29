//HintName: G.Models.TextToGraphRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToGraphRequest
    {
        /// <summary>
        /// The text to convert into a graph structure. Maximum of 35,000 words.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToGraphRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to convert into a graph structure. Maximum of 35,000 words.
        /// </param>
        public TextToGraphRequest(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToGraphRequest" /> class.
        /// </summary>
        public TextToGraphRequest()
        {
        }
    }
}