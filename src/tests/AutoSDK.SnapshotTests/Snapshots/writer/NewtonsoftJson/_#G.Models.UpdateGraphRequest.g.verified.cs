//HintName: G.Models.UpdateGraphRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGraphRequest
    {
        /// <summary>
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls")]
        public global::System.Collections.Generic.IList<global::G.UpdateGraphWebUrl>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters). Omitting this field leaves the name unchanged.
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters). Omitting this field leaves the description unchanged.
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs to update for this Knowledge Graph. You can only connect URLs to Knowledge Graphs with the type `web`. To clear the list of URLs, set this field to an empty array.
        /// </param>
        public UpdateGraphRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.UpdateGraphWebUrl>? urls)
        {
            this.Name = name;
            this.Description = description;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGraphRequest" /> class.
        /// </summary>
        public UpdateGraphRequest()
        {
        }
    }
}