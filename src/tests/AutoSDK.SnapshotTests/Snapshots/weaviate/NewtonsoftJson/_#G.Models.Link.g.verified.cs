//HintName: G.Models.Link.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Link
    {
        /// <summary>
        /// target of the link
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("href")]
        public string? Href { get; set; }

        /// <summary>
        /// relationship if both resources are related, e.g. 'next', 'previous', 'parent', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rel")]
        public string? Rel { get; set; }

        /// <summary>
        /// human readable name of the resource group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// weaviate documentation about this resource group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentationHref")]
        public string? DocumentationHref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}