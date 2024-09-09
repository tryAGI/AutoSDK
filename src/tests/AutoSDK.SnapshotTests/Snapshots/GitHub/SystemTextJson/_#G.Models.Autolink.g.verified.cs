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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlTemplate { get; set; }

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_alphanumeric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlphanumeric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}