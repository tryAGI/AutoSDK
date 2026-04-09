//HintName: G.Models.ScrapeOptionsActionPressAKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Press a key on the page. See https://asawicki.info/nosense/doc/devices/keyboard/key_codes.html for key codes.
    /// </summary>
    public sealed partial class ScrapeOptionsActionPressAKey
    {
        /// <summary>
        /// Press a key on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionPressAKeyTypeJsonConverter))]
        public global::G.ScrapeOptionsActionPressAKeyType Type { get; set; }

        /// <summary>
        /// Key to press<br/>
        /// Example: Enter
        /// </summary>
        /// <example>Enter</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionPressAKey" /> class.
        /// </summary>
        /// <param name="key">
        /// Key to press<br/>
        /// Example: Enter
        /// </param>
        /// <param name="type">
        /// Press a key on the page
        /// </param>
        public ScrapeOptionsActionPressAKey(
            string key,
            global::G.ScrapeOptionsActionPressAKeyType type)
        {
            this.Type = type;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionPressAKey" /> class.
        /// </summary>
        public ScrapeOptionsActionPressAKey()
        {
        }
    }
}