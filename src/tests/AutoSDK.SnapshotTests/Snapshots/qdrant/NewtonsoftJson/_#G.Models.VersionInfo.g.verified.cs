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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="version"></param>
        /// <param name="commit"></param>
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