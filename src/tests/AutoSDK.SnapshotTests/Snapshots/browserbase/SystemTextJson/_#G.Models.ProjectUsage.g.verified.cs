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
        [global::System.Text.Json.Serialization.JsonPropertyName("browserMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BrowserMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxyBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ProxyBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUsage" /> class.
        /// </summary>
        /// <param name="browserMinutes"></param>
        /// <param name="proxyBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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