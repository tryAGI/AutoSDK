//HintName: G.Models.GetVideoTranslationsApiResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVideoTranslationsApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranslationsItem> Translations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoTranslationsApiResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="translations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVideoTranslationsApiResponse(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::G.TranslationsItem> translations)
        {
            this.Id = id;
            this.Translations = translations ?? throw new global::System.ArgumentNullException(nameof(translations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoTranslationsApiResponse" /> class.
        /// </summary>
        public GetVideoTranslationsApiResponse()
        {
        }
    }
}