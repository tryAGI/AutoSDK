//HintName: G.Models.JobDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Document describing a job. JobConfig will be present in JobDetails returned for GET jobs/{id} request in SaaS and in Batch Appliance, but it will not be present in JobDetails returned as item in RetrieveJobsResponse in case of Batch Appliance.
    /// </summary>
    public sealed partial class JobDetails
    {
        /// <summary>
        /// The UTC date time the job was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </summary>
        /// <example>2018-01-09 12:29:01.853047+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the data file submitted for job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataName { get; set; }

        /// <summary>
        /// Name of the text file submitted to be aligned to audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_name")]
        public string? TextName { get; set; }

        /// <summary>
        /// The file duration (in seconds). May be missing for fetch URL jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The unique id assigned to the job.<br/>
        /// Example: a1b2c3d4e5
        /// </summary>
        /// <example>a1b2c3d4e5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the job. * `running` - The job is actively running. * `done` - The job completed successfully. * `rejected` - The job was accepted at first, but later could not be processed by the transcriber. * `deleted` - The user deleted the job. * `expired` - The system deleted the job. Usually because the job was in the `done` state for a very long time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobDetailsStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobDetailsStatus Status { get; set; }

        /// <summary>
        /// JSON object that contains various groups of job configuration<br/>
        /// parameters. Based on the value of `type`, a type-specific object<br/>
        /// such as `transcription_config` is required to be present to<br/>
        /// specify all configuration settings or parameters needed to<br/>
        /// process the job inputs as expected.<br/>
        /// If the results of the job are to be forwarded on completion,<br/>
        /// `notification_config` can be provided with a list of callbacks<br/>
        /// to be made; no assumptions should be made about the order in<br/>
        /// which they will occur.<br/>
        /// Customer specific job details or metadata can be supplied in<br/>
        /// `tracking`, and this information will be available where<br/>
        /// possible in the job results and in callbacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.JobConfig? Config { get; set; }

        /// <summary>
        /// Optional parameter used for backwards compatibility with v1 api
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Optional list of errors that have occurred in user interaction, for example: audio could not be fetched or notification could not be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::G.JobDetailError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetails" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UTC date time the job was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </param>
        /// <param name="dataName">
        /// Name of the data file submitted for job.
        /// </param>
        /// <param name="id">
        /// The unique id assigned to the job.<br/>
        /// Example: a1b2c3d4e5
        /// </param>
        /// <param name="status">
        /// The status of the job. * `running` - The job is actively running. * `done` - The job completed successfully. * `rejected` - The job was accepted at first, but later could not be processed by the transcriber. * `deleted` - The user deleted the job. * `expired` - The system deleted the job. Usually because the job was in the `done` state for a very long time.
        /// </param>
        /// <param name="textName">
        /// Name of the text file submitted to be aligned to audio.
        /// </param>
        /// <param name="duration">
        /// The file duration (in seconds). May be missing for fetch URL jobs.
        /// </param>
        /// <param name="config">
        /// JSON object that contains various groups of job configuration<br/>
        /// parameters. Based on the value of `type`, a type-specific object<br/>
        /// such as `transcription_config` is required to be present to<br/>
        /// specify all configuration settings or parameters needed to<br/>
        /// process the job inputs as expected.<br/>
        /// If the results of the job are to be forwarded on completion,<br/>
        /// `notification_config` can be provided with a list of callbacks<br/>
        /// to be made; no assumptions should be made about the order in<br/>
        /// which they will occur.<br/>
        /// Customer specific job details or metadata can be supplied in<br/>
        /// `tracking`, and this information will be available where<br/>
        /// possible in the job results and in callbacks.
        /// </param>
        /// <param name="lang">
        /// Optional parameter used for backwards compatibility with v1 api
        /// </param>
        /// <param name="errors">
        /// Optional list of errors that have occurred in user interaction, for example: audio could not be fetched or notification could not be sent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobDetails(
            global::System.DateTime createdAt,
            string dataName,
            string id,
            global::G.JobDetailsStatus status,
            string? textName,
            int? duration,
            global::G.JobConfig? config,
            string? lang,
            global::System.Collections.Generic.IList<global::G.JobDetailError>? errors)
        {
            this.CreatedAt = createdAt;
            this.DataName = dataName ?? throw new global::System.ArgumentNullException(nameof(dataName));
            this.TextName = textName;
            this.Duration = duration;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Config = config;
            this.Lang = lang;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetails" /> class.
        /// </summary>
        public JobDetails()
        {
        }
    }
}