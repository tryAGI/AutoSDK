//HintName: G.Models.Artifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// Absolute artifact path in the cloud agent environment<br/>
        /// Example: /opt/cursor/artifacts/screenshot.png
        /// </summary>
        /// <example>/opt/cursor/artifacts/screenshot.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("absolutePath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AbsolutePath { get; set; }

        /// <summary>
        /// Artifact file size in bytes<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Last modified timestamp for the artifact<br/>
        /// Example: 2024-01-15T11:02:00.000Z
        /// </summary>
        /// <example>2024-01-15T11:02:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="absolutePath">
        /// Absolute artifact path in the cloud agent environment<br/>
        /// Example: /opt/cursor/artifacts/screenshot.png
        /// </param>
        /// <param name="sizeBytes">
        /// Artifact file size in bytes<br/>
        /// Example: 12345
        /// </param>
        /// <param name="updatedAt">
        /// Last modified timestamp for the artifact<br/>
        /// Example: 2024-01-15T11:02:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            string absolutePath,
            long sizeBytes,
            global::System.DateTime updatedAt)
        {
            this.AbsolutePath = absolutePath ?? throw new global::System.ArgumentNullException(nameof(absolutePath));
            this.SizeBytes = sizeBytes;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }
    }
}