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
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestConfigAppInfo" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="workflowId"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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