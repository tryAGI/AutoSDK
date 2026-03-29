//HintName: G.Models.DirectoryUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for updating a directory.
    /// </summary>
    public sealed partial class DirectoryUpdateRequest
    {
        /// <summary>
        /// Updated name for the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description for the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name for the directory.
        /// </param>
        /// <param name="description">
        /// Updated description for the directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryUpdateRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryUpdateRequest" /> class.
        /// </summary>
        public DirectoryUpdateRequest()
        {
        }
    }
}