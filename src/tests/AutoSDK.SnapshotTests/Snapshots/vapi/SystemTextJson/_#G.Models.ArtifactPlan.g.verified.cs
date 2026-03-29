//HintName: G.Models.ArtifactPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactPlan
    {
        /// <summary>
        /// This determines whether assistant's calls are recorded. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you don't want to record the calls, set this to false.<br/>
        /// - If you want to record the calls when `assistant.hipaaEnabled` (deprecated) or `assistant.compliancePlan.hipaaEnabled` explicity set this to true and make sure to provide S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// You can find the recording at `call.artifact.recordingUrl` and `call.artifact.stereoRecordingUrl` after the call is ended.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// This determines the format of the recording. Defaults to `wav;l16`.<br/>
        /// @default 'wav;l16'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ArtifactPlanRecordingFormatJsonConverter))]
        public global::G.ArtifactPlanRecordingFormat? RecordingFormat { get; set; }

        /// <summary>
        /// This determines whether to use custom storage (S3 or GCP) for call recordings when storage credentials are configured.<br/>
        /// When set to false, recordings will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store recordings on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for recordings when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingUseCustomStorageEnabled")]
        public bool? RecordingUseCustomStorageEnabled { get; set; }

        /// <summary>
        /// This determines whether the video is recorded during the call. Defaults to false. Only relevant for `webCall` type.<br/>
        /// You can find the video recording at `call.artifact.videoRecordingUrl` after the call is ended.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingEnabled")]
        public bool? VideoRecordingEnabled { get; set; }

        /// <summary>
        /// This determines whether the artifact contains the full message history, even after handoff context engineering. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullMessageHistoryEnabled")]
        public bool? FullMessageHistoryEnabled { get; set; }

        /// <summary>
        /// This determines whether the SIP packet capture is enabled. Defaults to true. Only relevant for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.<br/>
        /// You can find the packet capture at `call.artifact.pcapUrl` after the call is ended.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pcapEnabled")]
        public bool? PcapEnabled { get; set; }

        /// <summary>
        /// This is the path where the SIP packet capture will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the packet capture to a specific path, set this to the path. Example: `/my-assistant-captures`.<br/>
        /// - If you want to upload the packet capture to the root of the bucket, set this to `/`.<br/>
        /// @default '/'<br/>
        /// Example: /pcaps
        /// </summary>
        /// <example>/pcaps</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pcapS3PathPrefix")]
        public string? PcapS3PathPrefix { get; set; }

        /// <summary>
        /// This determines whether to use custom storage (S3 or GCP) for SIP packet captures when storage credentials are configured.<br/>
        /// When set to false, packet captures will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store packet captures on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for packet captures when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pcapUseCustomStorageEnabled")]
        public bool? PcapUseCustomStorageEnabled { get; set; }

        /// <summary>
        /// This determines whether the call logs are enabled. Defaults to true.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loggingEnabled")]
        public bool? LoggingEnabled { get; set; }

        /// <summary>
        /// This determines whether to use custom storage (S3 or GCP) for call logs when storage credentials are configured.<br/>
        /// When set to false, logs will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store logs on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for logs when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loggingUseCustomStorageEnabled")]
        public bool? LoggingUseCustomStorageEnabled { get; set; }

        /// <summary>
        /// This is the plan for `call.artifact.transcript`. To disable, set `transcriptPlan.enabled` to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptPlan")]
        public global::G.TranscriptPlan? TranscriptPlan { get; set; }

        /// <summary>
        /// This is the path where the recording will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the recording to a specific path, set this to the path. Example: `/my-assistant-recordings`.<br/>
        /// - If you want to upload the recording to the root of the bucket, set this to `/`.<br/>
        /// @default '/'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingPath")]
        public string? RecordingPath { get; set; }

        /// <summary>
        /// This is an array of structured output IDs to be calculated during the call.<br/>
        /// The outputs will be extracted and stored in `call.artifact.structuredOutputs` after the call is ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputIds")]
        public global::System.Collections.Generic.IList<string>? StructuredOutputIds { get; set; }

        /// <summary>
        /// This is an array of transient structured outputs to be calculated during the call.<br/>
        /// The outputs will be extracted and stored in `call.artifact.structuredOutputs` after the call is ended.<br/>
        /// Use this to provide inline structured output configurations instead of referencing existing ones via structuredOutputIds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputs")]
        public global::System.Collections.Generic.IList<global::G.CreateStructuredOutputDTO>? StructuredOutputs { get; set; }

        /// <summary>
        /// This is an array of scorecard IDs that will be evaluated based on the structured outputs extracted during the call.<br/>
        /// The scorecards will be evaluated and the results will be stored in `call.artifact.scorecards` after the call has ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecardIds")]
        public global::System.Collections.Generic.IList<string>? ScorecardIds { get; set; }

        /// <summary>
        /// This is the array of scorecards that will be evaluated based on the structured outputs extracted during the call.<br/>
        /// The scorecards will be evaluated and the results will be stored in `call.artifact.scorecards` after the call has ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorecards")]
        public global::System.Collections.Generic.IList<global::G.CreateScorecardDTO>? Scorecards { get; set; }

        /// <summary>
        /// This is the path where the call logs will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the call logs to a specific path, set this to the path. Example: `/my-assistant-logs`.<br/>
        /// - If you want to upload the call logs to the root of the bucket, set this to `/`.<br/>
        /// @default '/'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loggingPath")]
        public string? LoggingPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPlan" /> class.
        /// </summary>
        /// <param name="recordingEnabled">
        /// This determines whether assistant's calls are recorded. Defaults to true.<br/>
        /// Usage:<br/>
        /// - If you don't want to record the calls, set this to false.<br/>
        /// - If you want to record the calls when `assistant.hipaaEnabled` (deprecated) or `assistant.compliancePlan.hipaaEnabled` explicity set this to true and make sure to provide S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// You can find the recording at `call.artifact.recordingUrl` and `call.artifact.stereoRecordingUrl` after the call is ended.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="recordingFormat">
        /// This determines the format of the recording. Defaults to `wav;l16`.<br/>
        /// @default 'wav;l16'
        /// </param>
        /// <param name="recordingUseCustomStorageEnabled">
        /// This determines whether to use custom storage (S3 or GCP) for call recordings when storage credentials are configured.<br/>
        /// When set to false, recordings will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store recordings on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for recordings when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="videoRecordingEnabled">
        /// This determines whether the video is recorded during the call. Defaults to false. Only relevant for `webCall` type.<br/>
        /// You can find the video recording at `call.artifact.videoRecordingUrl` after the call is ended.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="fullMessageHistoryEnabled">
        /// This determines whether the artifact contains the full message history, even after handoff context engineering. Defaults to false.<br/>
        /// Example: false
        /// </param>
        /// <param name="pcapEnabled">
        /// This determines whether the SIP packet capture is enabled. Defaults to true. Only relevant for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.<br/>
        /// You can find the packet capture at `call.artifact.pcapUrl` after the call is ended.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="pcapS3PathPrefix">
        /// This is the path where the SIP packet capture will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the packet capture to a specific path, set this to the path. Example: `/my-assistant-captures`.<br/>
        /// - If you want to upload the packet capture to the root of the bucket, set this to `/`.<br/>
        /// @default '/'<br/>
        /// Example: /pcaps
        /// </param>
        /// <param name="pcapUseCustomStorageEnabled">
        /// This determines whether to use custom storage (S3 or GCP) for SIP packet captures when storage credentials are configured.<br/>
        /// When set to false, packet captures will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store packet captures on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for packet captures when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="loggingEnabled">
        /// This determines whether the call logs are enabled. Defaults to true.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="loggingUseCustomStorageEnabled">
        /// This determines whether to use custom storage (S3 or GCP) for call logs when storage credentials are configured.<br/>
        /// When set to false, logs will be stored on Vapi's storage instead of your custom storage, even if you have custom storage credentials configured.<br/>
        /// Usage:<br/>
        /// - Set to false if you have custom storage configured but want to store logs on Vapi's storage for this assistant.<br/>
        /// - Set to true (or leave unset) to use your custom storage for logs when available.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="transcriptPlan">
        /// This is the plan for `call.artifact.transcript`. To disable, set `transcriptPlan.enabled` to false.
        /// </param>
        /// <param name="recordingPath">
        /// This is the path where the recording will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the recording to a specific path, set this to the path. Example: `/my-assistant-recordings`.<br/>
        /// - If you want to upload the recording to the root of the bucket, set this to `/`.<br/>
        /// @default '/'
        /// </param>
        /// <param name="structuredOutputIds">
        /// This is an array of structured output IDs to be calculated during the call.<br/>
        /// The outputs will be extracted and stored in `call.artifact.structuredOutputs` after the call is ended.
        /// </param>
        /// <param name="structuredOutputs">
        /// This is an array of transient structured outputs to be calculated during the call.<br/>
        /// The outputs will be extracted and stored in `call.artifact.structuredOutputs` after the call is ended.<br/>
        /// Use this to provide inline structured output configurations instead of referencing existing ones via structuredOutputIds.
        /// </param>
        /// <param name="scorecardIds">
        /// This is an array of scorecard IDs that will be evaluated based on the structured outputs extracted during the call.<br/>
        /// The scorecards will be evaluated and the results will be stored in `call.artifact.scorecards` after the call has ended.
        /// </param>
        /// <param name="scorecards">
        /// This is the array of scorecards that will be evaluated based on the structured outputs extracted during the call.<br/>
        /// The scorecards will be evaluated and the results will be stored in `call.artifact.scorecards` after the call has ended.
        /// </param>
        /// <param name="loggingPath">
        /// This is the path where the call logs will be uploaded. This is only used if you have provided S3 or GCP credentials on the Provider Credentials page in the Dashboard.<br/>
        /// If credential.s3PathPrefix or credential.bucketPlan.path is set, this will append to it.<br/>
        /// Usage:<br/>
        /// - If you want to upload the call logs to a specific path, set this to the path. Example: `/my-assistant-logs`.<br/>
        /// - If you want to upload the call logs to the root of the bucket, set this to `/`.<br/>
        /// @default '/'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactPlan(
            bool? recordingEnabled,
            global::G.ArtifactPlanRecordingFormat? recordingFormat,
            bool? recordingUseCustomStorageEnabled,
            bool? videoRecordingEnabled,
            bool? fullMessageHistoryEnabled,
            bool? pcapEnabled,
            string? pcapS3PathPrefix,
            bool? pcapUseCustomStorageEnabled,
            bool? loggingEnabled,
            bool? loggingUseCustomStorageEnabled,
            global::G.TranscriptPlan? transcriptPlan,
            string? recordingPath,
            global::System.Collections.Generic.IList<string>? structuredOutputIds,
            global::System.Collections.Generic.IList<global::G.CreateStructuredOutputDTO>? structuredOutputs,
            global::System.Collections.Generic.IList<string>? scorecardIds,
            global::System.Collections.Generic.IList<global::G.CreateScorecardDTO>? scorecards,
            string? loggingPath)
        {
            this.RecordingEnabled = recordingEnabled;
            this.RecordingFormat = recordingFormat;
            this.RecordingUseCustomStorageEnabled = recordingUseCustomStorageEnabled;
            this.VideoRecordingEnabled = videoRecordingEnabled;
            this.FullMessageHistoryEnabled = fullMessageHistoryEnabled;
            this.PcapEnabled = pcapEnabled;
            this.PcapS3PathPrefix = pcapS3PathPrefix;
            this.PcapUseCustomStorageEnabled = pcapUseCustomStorageEnabled;
            this.LoggingEnabled = loggingEnabled;
            this.LoggingUseCustomStorageEnabled = loggingUseCustomStorageEnabled;
            this.TranscriptPlan = transcriptPlan;
            this.RecordingPath = recordingPath;
            this.StructuredOutputIds = structuredOutputIds;
            this.StructuredOutputs = structuredOutputs;
            this.ScorecardIds = scorecardIds;
            this.Scorecards = scorecards;
            this.LoggingPath = loggingPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactPlan" /> class.
        /// </summary>
        public ArtifactPlan()
        {
        }
    }
}