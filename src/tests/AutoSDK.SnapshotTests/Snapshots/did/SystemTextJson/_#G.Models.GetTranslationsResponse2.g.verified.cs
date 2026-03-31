//HintName: G.Models.GetTranslationsResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetTranslationsResponseTranslation2> Translations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponse2" /> class.
        /// </summary>
        /// <param name="translations"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranslationsResponse2(
            global::System.Collections.Generic.IList<global::G.GetTranslationsResponseTranslation2> translations,
            string? token)
        {
            this.Translations = translations ?? throw new global::System.ArgumentNullException(nameof(translations));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationsResponse2" /> class.
        /// </summary>
        public GetTranslationsResponse2()
        {
        }
    }
}