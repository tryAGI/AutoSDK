﻿//HintName: G.Models.EmbedByTypeResponse.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::G.EmbedByTypeResponseEmbeddings Embeddings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The image entries for which embeddings were returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::G.Image>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedByTypeResponseResponseTypeJsonConverter))]
        public global::G.EmbedByTypeResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// The text entries for which embeddings were returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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