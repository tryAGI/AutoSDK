//HintName: G.Models.EmbedByTypeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedByTypeResponse
    {
        /// <summary>
        /// An object with different embedding types. The length of each embedding type array will be the same as the length of the original `texts` array.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("embeddings")]
        public global::G.EmbedByTypeResponseEmbeddings Embeddings { get; set; } = default!;

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
        public global::G.EmbedByTypeResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// The text entries for which embeddings were returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// An object with different embedding types. The length of each embedding type array will be the same as the length of the original `texts` array.<br/>
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
        public EmbedByTypeResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.Image>? images,
            global::G.ApiMeta? meta,
            global::G.EmbedByTypeResponseResponseType? responseType,
            global::System.Collections.Generic.IList<string>? texts,
            global::G.EmbedByTypeResponseEmbeddings embeddings = default!)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Embeddings = embeddings;
            this.Images = images;
            this.Meta = meta;
            this.ResponseType = responseType;
            this.Texts = texts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedByTypeResponse" /> class.
        /// </summary>
        public EmbedByTypeResponse()
        {
        }
    }
}