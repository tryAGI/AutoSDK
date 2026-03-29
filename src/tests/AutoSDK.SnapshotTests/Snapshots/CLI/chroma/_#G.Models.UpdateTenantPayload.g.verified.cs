//HintName: G.Models.UpdateTenantPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTenantPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTenantPayload" /> class.
        /// </summary>
        /// <param name="resourceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTenantPayload(
            string resourceName)
        {
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTenantPayload" /> class.
        /// </summary>
        public UpdateTenantPayload()
        {
        }
    }
}