//HintName: G.Models.ChatSDKRequestConfigAppInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestConfigAppInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfigAppInfo" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="workflowId"></param>
        /// <param name="parameters"></param>
        public ChatSDKRequestConfigAppInfo(
            string appId,
            string workflowId,
            object? parameters)
        {
            this.AppId = appId ?? throw new global::System.ArgumentNullException(nameof(appId));
            this.Parameters = parameters;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfigAppInfo" /> class.
        /// </summary>
        public ChatSDKRequestConfigAppInfo()
        {
        }
    }
}