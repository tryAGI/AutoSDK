//HintName: G.Models.LanguageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"language_id":"en","name":"English"}
    /// </summary>
    public sealed partial class LanguageResponseModel
    {
        /// <summary>
        /// The unique identifier of the language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageId { get; set; }

        /// <summary>
        /// The name of the language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageResponseModel" /> class.
        /// </summary>
        /// <param name="languageId">
        /// The unique identifier of the language.
        /// </param>
        /// <param name="name">
        /// The name of the language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageResponseModel(
            string languageId,
            string name)
        {
            this.LanguageId = languageId ?? throw new global::System.ArgumentNullException(nameof(languageId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageResponseModel" /> class.
        /// </summary>
        public LanguageResponseModel()
        {
        }
    }
}