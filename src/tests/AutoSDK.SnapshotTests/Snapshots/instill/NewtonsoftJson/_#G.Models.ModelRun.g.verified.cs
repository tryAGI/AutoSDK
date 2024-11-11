//HintName: G.Models.ModelRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ModelRun contains information about a run of models.
    /// </summary>
    public sealed partial class ModelRun
    {
        /// <summary>
        /// Model Run UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Model UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelUid")]
        public string? ModelUid { get; set; }

        /// <summary>
        /// Model run status.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.RunStatus? Status { get; set; }

        /// <summary>
        /// Run source.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.RunSource? Source { get; set; }

        /// <summary>
        /// Run total duration in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Run end time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Runner ID. If current viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runnerId")]
        public string? RunnerId { get; set; }

        /// <summary>
        /// The amount of Instill Credit consumed by the run. This field will only be present on Instill Cloud.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Error message occurred during model run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Model run created time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Model run updated time.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// The model version identifier, which is same as image tag.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Model inference input.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("taskInputs")]
        public global::System.Collections.Generic.IList<object>? TaskInputs { get; set; }

        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("taskOutputs")]
        public global::System.Collections.Generic.IList<object>? TaskOutputs { get; set; }

        /// <summary>
        /// Model ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Requester ID. This field might be empty if the model run belongs to a<br/>
        /// deleted namespace.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requesterId")]
        public string? RequesterId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        /// <param name="uid">
        /// Model Run UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modelUid">
        /// Model UUID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Model run status.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source">
        /// Run source.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Run total duration in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endTime">
        /// Run end time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="runnerId">
        /// Runner ID. If current viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// The amount of Instill Credit consumed by the run. This field will only be present on Instill Cloud.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message occurred during model run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Model run created time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Model run updated time.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="version">
        /// The model version identifier, which is same as image tag.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="taskInputs">
        /// Model inference input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="taskOutputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modelId">
        /// Model ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requesterId">
        /// Requester ID. This field might be empty if the model run belongs to a<br/>
        /// deleted namespace.<br/>
        /// Included only in responses
        /// </param>
        public ModelRun(
            string? uid,
            string? modelUid,
            global::G.RunStatus? status,
            global::G.RunSource? source,
            int? totalDuration,
            global::System.DateTime? endTime,
            string? runnerId,
            float? creditAmount,
            string? error,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? version,
            global::System.Collections.Generic.IList<object>? taskInputs,
            global::System.Collections.Generic.IList<object>? taskOutputs,
            string? modelId,
            string? requesterId)
        {
            this.Uid = uid;
            this.ModelUid = modelUid;
            this.Status = status;
            this.Source = source;
            this.TotalDuration = totalDuration;
            this.EndTime = endTime;
            this.RunnerId = runnerId;
            this.CreditAmount = creditAmount;
            this.Error = error;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.Version = version;
            this.TaskInputs = taskInputs;
            this.TaskOutputs = taskOutputs;
            this.ModelId = modelId;
            this.RequesterId = requesterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        public ModelRun()
        {
        }
    }
}