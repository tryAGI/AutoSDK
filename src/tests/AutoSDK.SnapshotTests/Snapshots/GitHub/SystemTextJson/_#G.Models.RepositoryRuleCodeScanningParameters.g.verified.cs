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
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RepositoryRuleParamsCodeScanningTool> CodeScanningTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}