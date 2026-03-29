//HintName: G.Models.OpenAPIUpdateOrganizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIUpdateOrganizationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        public OpenAPIUpdateOrganizationRequest(
            string? description,
            string? name)
        {
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateOrganizationRequest" /> class.
        /// </summary>
        public OpenAPIUpdateOrganizationRequest()
        {
        }
    }
}