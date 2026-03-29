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
        [global::Newtonsoft.Json.JsonProperty("absolutePath", Required = global::Newtonsoft.Json.Required.Always)]
        public string AbsolutePath { get; set; } = default!;

        /// <summary>
        /// Artifact file size in bytes<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::Newtonsoft.Json.JsonProperty("sizeBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long SizeBytes { get; set; } = default!;

        /// <summary>
        /// Last modified timestamp for the artifact<br/>
        /// Example: 2024-01-15T11:02:00.000Z
        /// </summary>
        /// <example>2024-01-15T11:02:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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