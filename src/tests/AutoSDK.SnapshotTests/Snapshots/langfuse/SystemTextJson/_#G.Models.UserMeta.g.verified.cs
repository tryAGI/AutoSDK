//HintName: G.Models.UserMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMeta
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public string? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMeta" /> class.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="created"></param>
        /// <param name="lastModified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMeta(
            string resourceType,
            string? created,
            string? lastModified)
        {
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.Created = created;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMeta" /> class.
        /// </summary>
        public UserMeta()
        {
        }
    }
}