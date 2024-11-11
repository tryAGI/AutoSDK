//HintName: G.Models.ApiPolicyAllowedOperations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operations that are allowed by the API role. Each operation may only allow<br/>
    /// certain resources that are described by a resource path to resource value<br/>
    /// map. If the value is null, then the operation is allowed on any resource.
    /// </summary>
    public sealed partial class ApiPolicyAllowedOperations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPolicyAllowedOperations" /> class.
        /// </summary>
        public ApiPolicyAllowedOperations(
 )
        {
        }
    }
}