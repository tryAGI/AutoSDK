//HintName: G.Models.KeyUsageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for a specific API key (without date grouping).
    /// </summary>
    public sealed partial class KeyUsageItem
    {
        /// <summary>
        /// Masked API key identifier.<br/>
        /// Example: db96****cb2c
        /// </summary>
        /// <example>db96****cb2c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Label associated with the API key.<br/>
        /// Example: DeepL API Key Prod
        /// </summary>
        /// <example>DeepL API Key Prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_label")]
        public string? ApiKeyLabel { get; set; }

        /// <summary>
        /// Breakdown of character usage by category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.UsageBreakdown? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyUsageItem" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Masked API key identifier.<br/>
        /// Example: db96****cb2c
        /// </param>
        /// <param name="apiKeyLabel">
        /// Label associated with the API key.<br/>
        /// Example: DeepL API Key Prod
        /// </param>
        /// <param name="usage">
        /// Breakdown of character usage by category.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyUsageItem(
            string? apiKey,
            string? apiKeyLabel,
            global::G.UsageBreakdown? usage)
        {
            this.ApiKey = apiKey;
            this.ApiKeyLabel = apiKeyLabel;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyUsageItem" /> class.
        /// </summary>
        public KeyUsageItem()
        {
        }
    }
}