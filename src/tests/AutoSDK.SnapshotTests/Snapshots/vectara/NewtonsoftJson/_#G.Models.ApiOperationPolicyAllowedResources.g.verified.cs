//HintName: G.Models.ApiOperationPolicyAllowedResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object with keys of resource paths to a list of allowed resources. A resource path starts with either body, path, or implicit. A body or path resource is within the operation body, and an implicit resource is a resource implied by the request.
    /// </summary>
    public sealed partial class ApiOperationPolicyAllowedResources
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}