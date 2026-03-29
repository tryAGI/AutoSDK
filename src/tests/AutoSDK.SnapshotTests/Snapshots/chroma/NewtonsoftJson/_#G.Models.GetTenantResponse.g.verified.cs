//HintName: G.Models.GetTenantResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTenantResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_name")]
        public string? ResourceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTenantResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceName"></param>
        public GetTenantResponse(
            string name,
            string? resourceName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ResourceName = resourceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTenantResponse" /> class.
        /// </summary>
        public GetTenantResponse()
        {
        }
    }
}