//HintName: G.Models.SpreadsheetJob.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A spreadsheet parsing job
    /// </summary>
    public sealed partial class SpreadsheetJob
    {
        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Configuration for the parsing job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpreadsheetParsingConfig Config { get; set; } = default!;

        /// <summary>
        /// The status of the parsing job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StatusEnumJsonConverter))]
        public global::G.StatusEnum Status { get; set; } = default!;

        /// <summary>
        /// When the job was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// When the job was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the job completed successfully
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// All extracted regions (populated when job is complete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regions")]
        public global::System.Collections.Generic.IList<global::G.ExtractedRegionSummary>? Regions { get; set; }

        /// <summary>
        /// Metadata for each processed worksheet (populated when job is complete)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("worksheet_metadata")]
        public global::System.Collections.Generic.IList<global::G.WorksheetMetadata>? WorksheetMetadata { get; set; }

        /// <summary>
        /// Any errors encountered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// The ID of the input file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// [DEPRECATED] The file that was parsed. Use file_id instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="userId">
        /// The ID of the user
        /// </param>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="config">
        /// Configuration for the parsing job
        /// </param>
        /// <param name="status">
        /// The status of the parsing job
        /// </param>
        /// <param name="createdAt">
        /// When the job was created
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated
        /// </param>
        /// <param name="success">
        /// Whether the job completed successfully
        /// </param>
        /// <param name="regions">
        /// All extracted regions (populated when job is complete)
        /// </param>
        /// <param name="worksheetMetadata">
        /// Metadata for each processed worksheet (populated when job is complete)
        /// </param>
        /// <param name="errors">
        /// Any errors encountered
        /// </param>
        /// <param name="fileId">
        /// The ID of the input file
        /// </param>
        public SpreadsheetJob(
            string id,
            string userId,
            global::System.Guid projectId,
            global::G.SpreadsheetParsingConfig config,
            global::G.StatusEnum status,
            string createdAt,
            string updatedAt,
            bool? success,
            global::System.Collections.Generic.IList<global::G.ExtractedRegionSummary>? regions,
            global::System.Collections.Generic.IList<global::G.WorksheetMetadata>? worksheetMetadata,
            global::System.Collections.Generic.IList<string>? errors,
            global::System.Guid? fileId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ProjectId = projectId;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Success = success;
            this.Regions = regions;
            this.WorksheetMetadata = worksheetMetadata;
            this.Errors = errors;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJob" /> class.
        /// </summary>
        public SpreadsheetJob()
        {
        }
    }
}