//HintName: G.Models.VersionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VersionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="version"></param>
        /// <param name="commit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionInfo(
            string title,
            string version,
            string? commit)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Commit = commit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        public VersionInfo()
        {
        }
    }
}