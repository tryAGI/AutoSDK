//HintName: G.Models.Artifact.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// These are the messages that were spoken during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// These are the messages that were spoken during the call, formatted for OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagesOpenAIFormatted")]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage>? MessagesOpenAIFormatted { get; set; }

        /// <summary>
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stereoRecordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StereoRecordingUrl { get; set; }

        /// <summary>
        /// This is video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? VideoRecordingUrl { get; set; }

        /// <summary>
        /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingStartDelaySeconds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? VideoRecordingStartDelaySeconds { get; set; }

        /// <summary>
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording")]
        public global::G.Recording? Recording { get; set; }

        /// <summary>
        /// This is the transcript of the call. This is derived from `artifact.messages` but provided for convenience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// This is the packet capture url for the call. This is only available for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pcapUrl")]
        public string? PcapUrl { get; set; }

        /// <summary>
        /// This is the url for the call logs. This includes all logging output during the call for debugging purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logUrl")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// This is the history of workflow nodes that were executed during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.NodeArtifact>? Nodes { get; set; }

        /// <summary>
        /// Ordered list of assistants that were active during the call, including after transfers and handoffs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantActivations")]
        public global::System.Collections.Generic.IList<global::G.AssistantActivation>? AssistantActivations { get; set; }

        /// <summary>
        /// These are the variable values at the end of the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableValues")]
        public object? VariableValues { get; set; }

        /// <summary>
        /// This is the performance metrics for the call. It contains the turn latency, broken down by component.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performanceMetrics")]
        public global::G.PerformanceMetrics? PerformanceMetrics { get; set; }

        /// <summary>
        /// These are the structured outputs that will be extracted from the call.<br/>
        /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputs")]
        public object? StructuredOutputs { get; set; }

        /// <summary>
        /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.<br/>
        /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecards")]
        public object? Scorecards { get; set; }

        /// <summary>
        /// These are the transfer records from warm transfers, including destinations, transcripts, and status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        public global::System.Collections.Generic.IList<string>? Transfers { get; set; }

        /// <summary>
        /// This is when the structured outputs were last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputsLastUpdatedAt")]
        public global::System.DateTime? StructuredOutputsLastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages that were spoken during the call.
        /// </param>
        /// <param name="messagesOpenAIFormatted">
        /// These are the messages that were spoken during the call, formatted for OpenAI.
        /// </param>
        /// <param name="recording">
        /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
        /// <param name="transcript">
        /// This is the transcript of the call. This is derived from `artifact.messages` but provided for convenience.
        /// </param>
        /// <param name="pcapUrl">
        /// This is the packet capture url for the call. This is only available for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.
        /// </param>
        /// <param name="logUrl">
        /// This is the url for the call logs. This includes all logging output during the call for debugging purposes.
        /// </param>
        /// <param name="nodes">
        /// This is the history of workflow nodes that were executed during the call.
        /// </param>
        /// <param name="assistantActivations">
        /// Ordered list of assistants that were active during the call, including after transfers and handoffs.
        /// </param>
        /// <param name="variableValues">
        /// These are the variable values at the end of the workflow execution.
        /// </param>
        /// <param name="performanceMetrics">
        /// This is the performance metrics for the call. It contains the turn latency, broken down by component.
        /// </param>
        /// <param name="structuredOutputs">
        /// These are the structured outputs that will be extracted from the call.<br/>
        /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
        /// </param>
        /// <param name="scorecards">
        /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.<br/>
        /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
        /// </param>
        /// <param name="transfers">
        /// These are the transfer records from warm transfers, including destinations, transcripts, and status.
        /// </param>
        /// <param name="structuredOutputsLastUpdatedAt">
        /// This is when the structured outputs were last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            global::System.Collections.Generic.IList<global::G.OpenAIMessage>? messagesOpenAIFormatted,
            global::G.Recording? recording,
            string? transcript,
            string? pcapUrl,
            string? logUrl,
            global::System.Collections.Generic.IList<global::G.NodeArtifact>? nodes,
            global::System.Collections.Generic.IList<global::G.AssistantActivation>? assistantActivations,
            object? variableValues,
            global::G.PerformanceMetrics? performanceMetrics,
            object? structuredOutputs,
            object? scorecards,
            global::System.Collections.Generic.IList<string>? transfers,
            global::System.DateTime? structuredOutputsLastUpdatedAt)
        {
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted;
            this.Recording = recording;
            this.Transcript = transcript;
            this.PcapUrl = pcapUrl;
            this.LogUrl = logUrl;
            this.Nodes = nodes;
            this.AssistantActivations = assistantActivations;
            this.VariableValues = variableValues;
            this.PerformanceMetrics = performanceMetrics;
            this.StructuredOutputs = structuredOutputs;
            this.Scorecards = scorecards;
            this.Transfers = transfers;
            this.StructuredOutputsLastUpdatedAt = structuredOutputsLastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }
    }
}