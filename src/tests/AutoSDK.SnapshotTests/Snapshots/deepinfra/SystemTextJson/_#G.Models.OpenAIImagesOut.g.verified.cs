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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// List of generated images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OpenAIImageData> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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