//HintName: G.Models.ApiPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// What actions a principal can take on the Vectara platform.
    /// </summary>
    public sealed partial class ApiPolicy
    {
        /// <summary>
        /// The name of the API role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Operations that are allowed by the API role. Each operation may only allow<br/>
        /// certain resources that are described by a resource path to resource value<br/>
        /// map. If the value is null, then the operation is allowed on any resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_operations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.ApiOperationPolicy> AllowedOperations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPolicy" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the API role.
        /// </param>
        /// <param name="allowedOperations">
        /// Operations that are allowed by the API role. Each operation may only allow<br/>
        /// certain resources that are described by a resource path to resource value<br/>
        /// map. If the value is null, then the operation is allowed on any resource.
        /// </param>
        public ApiPolicy(
            string name,
            global::System.Collections.Generic.Dictionary<string, global::G.ApiOperationPolicy> allowedOperations)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AllowedOperations = allowedOperations ?? throw new global::System.ArgumentNullException(nameof(allowedOperations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPolicy" /> class.
        /// </summary>
        public ApiPolicy()
        {
        }
    }
}