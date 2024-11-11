//HintName: G.Models.LinkWithType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hypermedia Link with Type
    /// </summary>
    public sealed partial class LinkWithType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href", Required = global::Newtonsoft.Json.Required.Always)]
        public string Href { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkWithType" /> class.
        /// </summary>
        /// <param name="href"></param>
        /// <param name="type"></param>
        public LinkWithType(
            string href,
            string type)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkWithType" /> class.
        /// </summary>
        public LinkWithType()
        {
        }
    }
}