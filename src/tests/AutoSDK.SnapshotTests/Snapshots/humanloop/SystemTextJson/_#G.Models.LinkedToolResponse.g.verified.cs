//HintName: G.Models.LinkedToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkedToolResponse
    {
        /// <summary>
        /// Unique identifier for the linked tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the linked tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Version ID of the linked tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedToolResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the linked tool.
        /// </param>
        /// <param name="name">
        /// Name of the linked tool.
        /// </param>
        /// <param name="versionId">
        /// Version ID of the linked tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkedToolResponse(
            string id,
            string? name,
            string? versionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedToolResponse" /> class.
        /// </summary>
        public LinkedToolResponse()
        {
        }
    }
}