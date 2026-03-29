//HintName: G.Models.CloudSharepointDataSourceIncludePathPatterns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of regex patterns for file paths to include. Full paths (including filename) must match at least one pattern to be included. Example: ['/reports/', '/docs/.*\.pdf$', '^Report.*\.pdf$']
    /// </summary>
    public sealed partial class CloudSharepointDataSourceIncludePathPatterns
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}