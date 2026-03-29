//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items
    {
        /// <summary>
        /// The type of content ('input_text', 'output_text', and 'input_image').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text to provide.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1ItemsImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Specifies the detail level of the image. Defaults to `auto`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content ('input_text', 'output_text', and 'input_image').
        /// </param>
        /// <param name="text">
        /// The text to provide.
        /// </param>
        /// <param name="imageUrl">
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </param>
        /// <param name="detail">
        /// Specifies the detail level of the image. Defaults to `auto`.
        /// </param>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items(
            string? type,
            string? text,
            global::G.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1ItemsImageUrl? imageUrl,
            string? detail)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items" /> class.
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items()
        {
        }
    }
}