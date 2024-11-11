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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The prefix of a key that is linkified.<br/>
        /// Example: TICKET-
        /// </summary>
        /// <example>TICKET-</example>
        [global::Newtonsoft.Json.JsonProperty("key_prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyPrefix { get; set; } = default!;

        /// <summary>
        /// A template for the target URL that is generated if a key was found.<br/>
        /// Example: https://example.com/TICKET?query=&lt;num&gt;
        /// </summary>
        /// <example>https://example.com/TICKET?query=&lt;num&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("url_template", Required = global::Newtonsoft.Json.Required.Always)]
        public string UrlTemplate { get; set; } = default!;

        /// <summary>
        /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference only matches numeric characters.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_alphanumeric", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAlphanumeric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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