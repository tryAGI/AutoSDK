//HintName: G.Models.ProjectSettingsRemoteEvalSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSettingsRemoteEvalSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsRemoteEvalSource" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public ProjectSettingsRemoteEvalSource(
            string url,
            string? name,
            string? description)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSettingsRemoteEvalSource" /> class.
        /// </summary>
        public ProjectSettingsRemoteEvalSource()
        {
        }
    }
}