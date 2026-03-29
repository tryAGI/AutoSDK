//HintName: G.Models.DirectorySyncJobCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating a directory sync job.
    /// </summary>
    public sealed partial class DirectorySyncJobCreateRequest
    {
        /// <summary>
        /// Directory being processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySyncJobCreateRequest" /> class.
        /// </summary>
        /// <param name="directoryId">
        /// Directory being processed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectorySyncJobCreateRequest(
            string directoryId)
        {
            this.DirectoryId = directoryId ?? throw new global::System.ArgumentNullException(nameof(directoryId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySyncJobCreateRequest" /> class.
        /// </summary>
        public DirectorySyncJobCreateRequest()
        {
        }
    }
}