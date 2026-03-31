//HintName: G.Models.CreateRequest3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest3
    {
        /// <summary>
        /// The language of the consent.<br/>
        /// Supported languages: Dutch, Turkish, Swedish, Indonesian, Filipino, Czech, Romanian, Danish, Malay, Slovak, Croatian, English, Polish, German, Spanish, French, Italian, Portuguese<br/>
        /// Example: english
        /// </summary>
        /// <example>english</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest3" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the consent.<br/>
        /// Supported languages: Dutch, Turkish, Swedish, Indonesian, Filipino, Czech, Romanian, Danish, Malay, Slovak, Croatian, English, Polish, German, Spanish, French, Italian, Portuguese<br/>
        /// Example: english
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest3(
            string language)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest3" /> class.
        /// </summary>
        public CreateRequest3()
        {
        }
    }
}