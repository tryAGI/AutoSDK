//HintName: G.Models.ArchiveUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for updating an archive (partial).<br/>
    /// Supports updating only name and description.
    /// </summary>
    public sealed partial class ArchiveUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArchiveUpdateRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveUpdateRequest" /> class.
        /// </summary>
        public ArchiveUpdateRequest()
        {
        }
    }
}