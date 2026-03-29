//HintName: G.Models.MultiInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `multi_input`.
    /// </summary>
    public sealed partial class MultiInputRequest
    {
        /// <summary>
        /// Text to combine with the images when generating the embedding.<br/>
        /// **Usage options**:<br/>
        /// - Omit this field to create an embedding from images only.<br/>
        /// - Provide plain text to add context. Example: "A person cooking."<br/>
        /// - Use image references to describe relationships between specific images. The format is `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Example: "A person wearing &lt;@outfit&gt; and holding &lt;@accessory&gt;."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// An array of up to 10 images to include in the embedding. The platform processes images in the order they appear in the array. If you use image references in the [`input_text`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.multi_input.input_text) parameter, each must have a corresponding image with a matching `name` field. If an image reference has no match, the request fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MultiInputMediaSource> MediaSources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSources">
        /// An array of up to 10 images to include in the embedding. The platform processes images in the order they appear in the array. If you use image references in the [`input_text`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.multi_input.input_text) parameter, each must have a corresponding image with a matching `name` field. If an image reference has no match, the request fails.
        /// </param>
        /// <param name="inputText">
        /// Text to combine with the images when generating the embedding.<br/>
        /// **Usage options**:<br/>
        /// - Omit this field to create an embedding from images only.<br/>
        /// - Provide plain text to add context. Example: "A person cooking."<br/>
        /// - Use image references to describe relationships between specific images. The format is `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Example: "A person wearing &lt;@outfit&gt; and holding &lt;@accessory&gt;."
        /// </param>
        public MultiInputRequest(
            global::System.Collections.Generic.IList<global::G.MultiInputMediaSource> mediaSources,
            string? inputText)
        {
            this.InputText = inputText;
            this.MediaSources = mediaSources ?? throw new global::System.ArgumentNullException(nameof(mediaSources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputRequest" /> class.
        /// </summary>
        public MultiInputRequest()
        {
        }
    }
}