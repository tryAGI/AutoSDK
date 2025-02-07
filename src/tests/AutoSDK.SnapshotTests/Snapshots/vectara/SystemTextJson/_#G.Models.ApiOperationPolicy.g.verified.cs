//HintName: G.Models.ApiOperationPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy to allow operations if only using the specified resource.
    /// </summary>
    public sealed partial class ApiOperationPolicy
    {
        /// <summary>
        /// If any resource is allowed for the operation.<br/>
        /// Default Value: true
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_any_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAnyResource { get; set; } = true;

        /// <summary>
        /// Object with keys of resource paths to a list of allowed resources.<br/>
        /// A resource path starts with either body, path, or implicit.<br/>
        /// A body or path resource is within the operation body, and an implicit<br/>
        /// resource is a resource implied by the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_resources")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? AllowedResources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOperationPolicy" /> class.
        /// </summary>
        /// <param name="allowAnyResource">
        /// If any resource is allowed for the operation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowedResources">
        /// Object with keys of resource paths to a list of allowed resources.<br/>
        /// A resource path starts with either body, path, or implicit.<br/>
        /// A body or path resource is within the operation body, and an implicit<br/>
        /// resource is a resource implied by the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOperationPolicy(
            bool allowAnyResource,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? allowedResources)
        {
            this.AllowAnyResource = allowAnyResource;
            this.AllowedResources = allowedResources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOperationPolicy" /> class.
        /// </summary>
        public ApiOperationPolicy()
        {
        }
    }
}