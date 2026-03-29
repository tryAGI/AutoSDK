//HintName: G.Models.GetAuthConfigsByNanoidResponseToolAccessConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAuthConfigsByNanoidResponseToolAccessConfig
    {
        /// <summary>
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_for_connected_account_creation")]
        public global::System.Collections.Generic.IList<string>? ToolsForConnectedAccountCreation { get; set; }

        /// <summary>
        /// The actions that the user can perform on the auth config. If passed, this will update the actions that the user can perform on the auth config.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_available_for_execution")]
        public global::System.Collections.Generic.IList<string>? ToolsAvailableForExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseToolAccessConfig" /> class.
        /// </summary>
        /// <param name="toolsForConnectedAccountCreation">
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="toolsAvailableForExecution">
        /// The actions that the user can perform on the auth config. If passed, this will update the actions that the user can perform on the auth config.<br/>
        /// Default Value: []
        /// </param>
        public GetAuthConfigsByNanoidResponseToolAccessConfig(
            global::System.Collections.Generic.IList<string>? toolsForConnectedAccountCreation,
            global::System.Collections.Generic.IList<string>? toolsAvailableForExecution)
        {
            this.ToolsForConnectedAccountCreation = toolsForConnectedAccountCreation;
            this.ToolsAvailableForExecution = toolsAvailableForExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseToolAccessConfig" /> class.
        /// </summary>
        public GetAuthConfigsByNanoidResponseToolAccessConfig()
        {
        }
    }
}