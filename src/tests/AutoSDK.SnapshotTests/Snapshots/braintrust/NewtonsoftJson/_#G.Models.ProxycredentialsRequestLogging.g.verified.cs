//HintName: G.Models.ProxycredentialsRequestLogging.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If present, proxy will log requests to the given Braintrust project name.
    /// </summary>
    public sealed partial class ProxycredentialsRequestLogging
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compress_audio")]
        public bool? CompressAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxycredentialsRequestLogging" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="compressAudio">
        /// Default Value: true
        /// </param>
        public ProxycredentialsRequestLogging(
            string projectName,
            bool? compressAudio)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.CompressAudio = compressAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxycredentialsRequestLogging" /> class.
        /// </summary>
        public ProxycredentialsRequestLogging()
        {
        }
    }
}