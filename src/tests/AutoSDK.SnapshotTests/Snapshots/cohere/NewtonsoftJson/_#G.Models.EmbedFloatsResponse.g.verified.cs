//HintName: G.Models.EmbedFloatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedFloatsResponse
    {
        /// <summary>
        /// An array of embeddings, where each embedding is an array of floats. The length of the `embeddings` array will be the same as the length of the original `texts` array.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("embeddings")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Embeddings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The image entries for which embeddings were returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.Image>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_type")]
        public global::G.EmbedFloatsResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// The text entries for which embeddings were returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Texts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedFloatsResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// An array of embeddings, where each embedding is an array of floats. The length of the `embeddings` array will be the same as the length of the original `texts` array.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id"></param>
        /// <param name="images">
        /// The image entries for which embeddings were returned.
        /// </param>
        /// <param name="meta"></param>
        /// <param name="responseType"></param>
        /// <param name="texts">
        /// The text entries for which embeddings were returned.
        /// </param>
        public EmbedFloatsResponse(
            string id,
            global::System.Collections.Generic.IList<string> texts,
            global::System.Collections.Generic.IList<global::G.Image>? images,
            global::G.ApiMeta? meta,
            global::G.EmbedFloatsResponseResponseType? responseType,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> embeddings = default!)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
            this.Embeddings = embeddings;
            this.Images = images;
            this.Meta = meta;
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedFloatsResponse" /> class.
        /// </summary>
        public EmbedFloatsResponse()
        {
        }
    }
}