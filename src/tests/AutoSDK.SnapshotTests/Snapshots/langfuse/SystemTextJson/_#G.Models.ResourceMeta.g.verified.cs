//HintName: G.Models.ResourceMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMeta" /> class.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="location"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceMeta(
            string resourceType,
            string location)
        {
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMeta" /> class.
        /// </summary>
        public ResourceMeta()
        {
        }
    }
}