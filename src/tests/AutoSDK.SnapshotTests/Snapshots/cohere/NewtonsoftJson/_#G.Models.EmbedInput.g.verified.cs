//HintName: G.Models.EmbedInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedInput
    {
        /// <summary>
        /// An array of objects containing the input data for the model to embed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbedContent> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedInput" /> class.
        /// </summary>
        /// <param name="content">
        /// An array of objects containing the input data for the model to embed.
        /// </param>
        public EmbedInput(
            global::System.Collections.Generic.IList<global::G.EmbedContent> content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedInput" /> class.
        /// </summary>
        public EmbedInput()
        {
        }
    }
}