//HintName: G.Models.PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig
    {
        /// <summary>
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_for_connected_account_creation")]
        public global::System.Collections.Generic.IList<string>? ToolsForConnectedAccountCreation { get; set; }

        /// <summary>
        /// The actions that the user can perform on the auth config. If passed, this will update the actions that the user can perform on the auth config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_available_for_execution")]
        public global::System.Collections.Generic.IList<string>? ToolsAvailableForExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig" /> class.
        /// </summary>
        /// <param name="toolsForConnectedAccountCreation">
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.
        /// </param>
        /// <param name="toolsAvailableForExecution">
        /// The actions that the user can perform on the auth config. If passed, this will update the actions that the user can perform on the auth config.
        /// </param>
        public PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig(
            global::System.Collections.Generic.IList<string>? toolsForConnectedAccountCreation,
            global::System.Collections.Generic.IList<string>? toolsAvailableForExecution)
        {
            this.ToolsForConnectedAccountCreation = toolsForConnectedAccountCreation;
            this.ToolsAvailableForExecution = toolsAvailableForExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig" /> class.
        /// </summary>
        public PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig()
        {
        }
    }
}