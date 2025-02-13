﻿//HintName: G.Models.PipelineRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PipelineRun represents a single execution of a pipeline.
    /// </summary>
    public sealed partial class PipelineRun
    {
        /// <summary>
        /// Unique identifier for the pipeline.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineUid")]
        public string? PipelineUid { get; set; }

        /// <summary>
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineRunUid")]
        public string? PipelineRunUid { get; set; }

        /// <summary>
        /// Pipeline version used in the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineVersion")]
        public string? PipelineVersion { get; set; }

        /// <summary>
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.RunStatus? Status { get; set; }

        /// <summary>
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.RunSource? Source { get; set; }

        /// <summary>
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Runner ID. If current viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runnerId")]
        public string? RunnerId { get; set; }

        /// <summary>
        /// Pipeline input parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// Pipeline inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Snapshot of the pipeline recipe used for this run.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recipeSnapshot")]
        public object? RecipeSnapshot { get; set; }

        /// <summary>
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completeTime")]
        public global::System.DateTime? CompleteTime { get; set; }

        /// <summary>
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSpecification")]
        public global::G.DataSpecification? DataSpecification { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineId")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Requester ID. This field might be empty if the pipeline run belongs to a<br/>
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
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        /// <param name="pipelineUid">
        /// Unique identifier for the pipeline.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineRunUid">
        /// Unique identifier for each run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineVersion">
        /// Pipeline version used in the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Current status of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="source">
        /// Origin of the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Time taken to complete the run in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="runnerId">
        /// Runner ID. If current viewing requester does not have enough permission, it will return null.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputs">
        /// Pipeline input parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputs">
        /// Pipeline inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="recipeSnapshot">
        /// Snapshot of the pipeline recipe used for this run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// Time when the run started execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completeTime">
        /// Time when the run completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message if the run failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dataSpecification">
        /// Data specifications.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pipelineId">
        /// Included only in responses
        /// </param>
        /// <param name="requesterId">
        /// Requester ID. This field might be empty if the pipeline run belongs to a<br/>
        /// deleted namespace.<br/>
        /// Included only in responses
        /// </param>
        public PipelineRun(
            string? pipelineUid,
            string? pipelineRunUid,
            string? pipelineVersion,
            global::G.RunStatus? status,
            global::G.RunSource? source,
            int? totalDuration,
            string? runnerId,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<object>? outputs,
            object? recipeSnapshot,
            global::System.DateTime? startTime,
            global::System.DateTime? completeTime,
            string? error,
            float? creditAmount,
            global::G.DataSpecification? dataSpecification,
            string? pipelineId,
            string? requesterId)
        {
            this.PipelineUid = pipelineUid;
            this.PipelineRunUid = pipelineRunUid;
            this.PipelineVersion = pipelineVersion;
            this.Status = status;
            this.Source = source;
            this.TotalDuration = totalDuration;
            this.RunnerId = runnerId;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.RecipeSnapshot = recipeSnapshot;
            this.StartTime = startTime;
            this.CompleteTime = completeTime;
            this.Error = error;
            this.CreditAmount = creditAmount;
            this.DataSpecification = dataSpecification;
            this.PipelineId = pipelineId;
            this.RequesterId = requesterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRun" /> class.
        /// </summary>
        public PipelineRun()
        {
        }
    }
}