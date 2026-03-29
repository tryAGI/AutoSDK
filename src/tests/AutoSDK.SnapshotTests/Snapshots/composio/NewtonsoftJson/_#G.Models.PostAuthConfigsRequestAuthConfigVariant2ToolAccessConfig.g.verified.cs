//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig
    {
        /// <summary>
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools_for_connected_account_creation")]
        public global::System.Collections.Generic.IList<string>? ToolsForConnectedAccountCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig" /> class.
        /// </summary>
        /// <param name="toolsForConnectedAccountCreation">
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes.<br/>
        /// Default Value: []
        /// </param>
        public PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig(
            global::System.Collections.Generic.IList<string>? toolsForConnectedAccountCreation)
        {
            this.ToolsForConnectedAccountCreation = toolsForConnectedAccountCreation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig" /> class.
        /// </summary>
        public PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig()
        {
        }
    }
}