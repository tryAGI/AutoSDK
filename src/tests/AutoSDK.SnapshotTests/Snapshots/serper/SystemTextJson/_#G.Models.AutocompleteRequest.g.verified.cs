//HintName: G.Models.AutocompleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutocompleteRequest
    {
        /// <summary>
        /// Partial query string for autocomplete suggestions.<br/>
        /// Example: apple
        /// </summary>
        /// <example>apple</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// Country code for localized suggestions (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gl")]
        public string? Gl { get; set; }

        /// <summary>
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hl")]
        public string? Hl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteRequest" /> class.
        /// </summary>
        /// <param name="q">
        /// Partial query string for autocomplete suggestions.<br/>
        /// Example: apple
        /// </param>
        /// <param name="gl">
        /// Country code for localized suggestions (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </param>
        /// <param name="hl">
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutocompleteRequest(
            string q,
            string? gl,
            string? hl)
        {
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Gl = gl;
            this.Hl = hl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteRequest" /> class.
        /// </summary>
        public AutocompleteRequest()
        {
        }
    }
}