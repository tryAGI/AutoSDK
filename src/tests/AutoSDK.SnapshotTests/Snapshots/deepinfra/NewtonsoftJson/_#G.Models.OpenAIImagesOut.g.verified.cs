//HintName: G.Models.OpenAIImagesOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImagesOut
    {
        /// <summary>
        /// Unix timestamp of when the images were created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// List of generated images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OpenAIImageData> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesOut" /> class.
        /// </summary>
        /// <param name="created">
        /// Unix timestamp of when the images were created
        /// </param>
        /// <param name="data">
        /// List of generated images
        /// </param>
        public OpenAIImagesOut(
            global::System.Collections.Generic.IList<global::G.OpenAIImageData> data,
            global::System.DateTimeOffset? created)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImagesOut" /> class.
        /// </summary>
        public OpenAIImagesOut()
        {
        }
    }
}