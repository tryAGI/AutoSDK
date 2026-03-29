//HintName: G.Models.CollectionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"collections":[{"name":"arxiv-title"},{"name":"arxiv-abstract"},{"name":"medium-title"},{"name":"medium-text"}]}
    /// </summary>
    public sealed partial class CollectionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CollectionDescription> Collections { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsResponse" /> class.
        /// </summary>
        /// <param name="collections"></param>
        public CollectionsResponse(
            global::System.Collections.Generic.IList<global::G.CollectionDescription> collections)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsResponse" /> class.
        /// </summary>
        public CollectionsResponse()
        {
        }
    }
}