//HintName: G.Models.CreateContainerBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContainerBody
    {
        /// <summary>
        /// Name of the container to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// IDs of files to copy to the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::G.CreateContainerBodyExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainerBody(
            string name,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::G.CreateContainerBodyExpiresAfter? expiresAfter)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FileIds = fileIds;
            this.ExpiresAfter = expiresAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        public CreateContainerBody()
        {
        }
    }
}