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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Operations that are allowed by the API role. Each operation may only allow<br/>
        /// certain resources that are described by a resource path to resource value<br/>
        /// map. If the value is null, then the operation is allowed on any resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.ApiOperationPolicy> AllowedOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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