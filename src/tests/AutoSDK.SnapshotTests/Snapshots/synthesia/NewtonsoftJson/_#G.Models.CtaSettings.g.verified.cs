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
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// URL to navigate to, when the call-to-action button is clicked.<br/>
        /// Example: [https://example.com, https://signup.example.com]
        /// </summary>
        /// <example>[https://example.com, https://signup.example.com]</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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