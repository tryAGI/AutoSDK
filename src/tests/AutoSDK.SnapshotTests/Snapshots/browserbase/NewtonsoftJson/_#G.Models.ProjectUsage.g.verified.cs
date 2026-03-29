//HintName: G.Models.ProjectUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browserMinutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int BrowserMinutes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxyBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long ProxyBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUsage" /> class.
        /// </summary>
        /// <param name="browserMinutes"></param>
        /// <param name="proxyBytes"></param>
        public ProjectUsage(
            int browserMinutes,
            long proxyBytes)
        {
            this.BrowserMinutes = browserMinutes;
            this.ProxyBytes = proxyBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUsage" /> class.
        /// </summary>
        public ProjectUsage()
        {
        }
    }
}