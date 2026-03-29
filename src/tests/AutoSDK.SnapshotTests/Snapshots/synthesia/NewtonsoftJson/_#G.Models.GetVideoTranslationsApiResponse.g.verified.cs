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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranslationsItem> Translations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVideoTranslationsApiResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="translations"></param>
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