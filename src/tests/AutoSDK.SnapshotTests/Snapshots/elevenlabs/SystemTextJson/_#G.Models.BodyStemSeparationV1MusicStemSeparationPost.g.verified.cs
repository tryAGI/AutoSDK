//HintName: G.Models.BodyStemSeparationV1MusicStemSeparationPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyStemSeparationV1MusicStemSeparationPost
    {
        /// <summary>
        /// The audio file to separate into stems.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The audio file to separate into stems.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The id of the stem variation to use.<br/>
        /// Default Value: six_stems_v1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem_variation_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter))]
        public global::G.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? StemVariationId { get; set; }

        /// <summary>
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sign_with_c2pa")]
        public bool? SignWithC2pa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStemSeparationV1MusicStemSeparationPost" /> class.
        /// </summary>
        /// <param name="file">
        /// The audio file to separate into stems.
        /// </param>
        /// <param name="filename">
        /// The audio file to separate into stems.
        /// </param>
        /// <param name="stemVariationId">
        /// The id of the stem variation to use.<br/>
        /// Default Value: six_stems_v1
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyStemSeparationV1MusicStemSeparationPost(
            byte[] file,
            string filename,
            global::G.BodyStemSeparationV1MusicStemSeparationPostStemVariationId? stemVariationId,
            bool? signWithC2pa)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.StemVariationId = stemVariationId;
            this.SignWithC2pa = signWithC2pa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStemSeparationV1MusicStemSeparationPost" /> class.
        /// </summary>
        public BodyStemSeparationV1MusicStemSeparationPost()
        {
        }
    }
}