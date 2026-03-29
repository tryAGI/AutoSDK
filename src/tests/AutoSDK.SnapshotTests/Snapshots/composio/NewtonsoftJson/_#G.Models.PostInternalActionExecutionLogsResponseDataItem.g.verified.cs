//HintName: G.Models.PostInternalActionExecutionLogsResponseDataItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ActionKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("appKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostInternalActionExecutionLogsResponseDataItemApp App { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectedAccountId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectedAccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostInternalActionExecutionLogsResponseDataItemStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("executionTime", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExecutionTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimalResponse", Required = global::Newtonsoft.Json.Required.Always)]
        public string MinimalResponse { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.PostInternalActionExecutionLogsResponseDataItemMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionKey"></param>
        /// <param name="appKey"></param>
        /// <param name="app"></param>
        /// <param name="connectedAccountId"></param>
        /// <param name="entityId"></param>
        /// <param name="status"></param>
        /// <param name="executionTime"></param>
        /// <param name="minimalResponse"></param>
        /// <param name="createdAt"></param>
        /// <param name="metadata"></param>
        public PostInternalActionExecutionLogsResponseDataItem(
            string id,
            string actionKey,
            string appKey,
            global::G.PostInternalActionExecutionLogsResponseDataItemApp app,
            string connectedAccountId,
            string entityId,
            global::G.PostInternalActionExecutionLogsResponseDataItemStatus status,
            double executionTime,
            string minimalResponse,
            double createdAt,
            global::G.PostInternalActionExecutionLogsResponseDataItemMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActionKey = actionKey ?? throw new global::System.ArgumentNullException(nameof(actionKey));
            this.AppKey = appKey ?? throw new global::System.ArgumentNullException(nameof(appKey));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Status = status;
            this.ExecutionTime = executionTime;
            this.MinimalResponse = minimalResponse ?? throw new global::System.ArgumentNullException(nameof(minimalResponse));
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItem" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsResponseDataItem()
        {
        }
    }
}