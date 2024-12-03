//HintName: G.Models.Autolink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An autolink reference.
    /// </summary>
    public sealed partial class Autolink
    {
        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </summary>
        /// <example>TICKET-</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </summary>
        /// <example>https://example.com/TICKET?query=&lt;num&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlTemplate { get; set; }

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_alphanumeric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlphanumeric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Autolink" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 3
        /// </param>
        /// <param name="keyPrefix">
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </param>
        /// <param name="urlTemplate">
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </param>
        /// <param name="isAlphanumeric">
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Autolink(
            int id,
            string keyPrefix,
            string urlTemplate,
            bool isAlphanumeric)
        {
            this.Id = id;
            this.KeyPrefix = keyPrefix ?? throw new global::System.ArgumentNullException(nameof(keyPrefix));
            this.UrlTemplate = urlTemplate ?? throw new global::System.ArgumentNullException(nameof(urlTemplate));
            this.IsAlphanumeric = isAlphanumeric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autolink" /> class.
        /// </summary>
        public Autolink()
        {
        }
    }
}