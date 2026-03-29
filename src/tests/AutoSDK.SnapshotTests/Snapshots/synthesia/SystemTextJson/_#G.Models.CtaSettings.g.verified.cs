//HintName: G.Models.CtaSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CtaSettings
    {
        /// <summary>
        /// Label for a call-to-action button.<br/>
        /// Example: [Learn More, Sign up]
        /// </summary>
        /// <example>[Learn More, Sign up]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// URL to navigate to, when the call-to-action button is clicked.<br/>
        /// Example: [https://example.com, https://signup.example.com]
        /// </summary>
        /// <example>[https://example.com, https://signup.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CtaSettings" /> class.
        /// </summary>
        /// <param name="label">
        /// Label for a call-to-action button.<br/>
        /// Example: [Learn More, Sign up]
        /// </param>
        /// <param name="url">
        /// URL to navigate to, when the call-to-action button is clicked.<br/>
        /// Example: [https://example.com, https://signup.example.com]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CtaSettings(
            string label,
            string url)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CtaSettings" /> class.
        /// </summary>
        public CtaSettings()
        {
        }
    }
}