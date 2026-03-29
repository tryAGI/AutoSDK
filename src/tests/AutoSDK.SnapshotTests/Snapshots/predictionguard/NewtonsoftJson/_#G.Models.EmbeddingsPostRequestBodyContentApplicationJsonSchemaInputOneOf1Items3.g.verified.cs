//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this option for multimodal input.
    /// </summary>
    public sealed partial class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3
    {
        /// <summary>
        /// The text to embed. You can choose to provide this or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The base64 encoding of an image. You can choose to provide this or not.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to embed. You can choose to provide this or not.
        /// </param>
        /// <param name="image">
        /// The base64 encoding of an image. You can choose to provide this or not.
        /// </param>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3(
            string? text,
            string? image)
        {
            this.Text = text;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3" /> class.
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3()
        {
        }
    }
}