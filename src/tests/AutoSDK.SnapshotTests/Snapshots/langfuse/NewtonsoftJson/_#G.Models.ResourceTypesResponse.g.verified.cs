//HintName: G.Models.ResourceTypesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceTypesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Schemas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalResults", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalResults { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("Resources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResourceType> Resources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypesResponse" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="totalResults"></param>
        /// <param name="resources"></param>
        public ResourceTypesResponse(
            global::System.Collections.Generic.IList<string> schemas,
            int totalResults,
            global::System.Collections.Generic.IList<global::G.ResourceType> resources)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.TotalResults = totalResults;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypesResponse" /> class.
        /// </summary>
        public ResourceTypesResponse()
        {
        }
    }
}