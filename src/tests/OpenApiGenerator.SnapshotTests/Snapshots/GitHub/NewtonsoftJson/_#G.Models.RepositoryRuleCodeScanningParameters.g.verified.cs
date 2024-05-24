//HintName: G.Models.RepositoryRuleCodeScanningParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleCodeScanningParameters
    {
        /// <summary>
        /// Tools that must provide code scanning results for this rule to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_scanning_tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<RepositoryRuleParamsCodeScanningTool> CodeScanningTools { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}