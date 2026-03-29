//HintName: G.Models.CloudSharepointDataSourceExcludePathPatterns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of regex patterns for file paths to exclude. Files whose paths (including filename) match any pattern will be excluded. Example: ['/temp/', '/backup/', '\.git/', '\.tmp$', '^~']
    /// </summary>
    public sealed partial class CloudSharepointDataSourceExcludePathPatterns
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}