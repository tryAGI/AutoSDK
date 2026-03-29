//HintName: G.Models.JobInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary information about an ASR job, to support identification and tracking.
    /// </summary>
    public sealed partial class JobInfo
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
        /// Name of data file submitted for job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataName { get; set; }

        /// <summary>
        /// The data file audio duration (in seconds).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The unique id assigned to the job.<br/>
        /// Example: a1b2c3d4e5
        /// </summary>
        /// <example>a1b2c3d4e5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the text file submitted to be aligned to audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_name")]
        public string? TextName { get; set; }

        /// <summary>
        /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
        /// </summary>
        /// <example>{"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking")]
        public global::G.TrackingData? Tracking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfo" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UTC date time the job was created.<br/>
        /// Example: 2018-01-09 12:29:01.853047+00:00
        /// </param>
        /// <param name="dataName">
        /// Name of data file submitted for job.
        /// </param>
        /// <param name="duration">
        /// The data file audio duration (in seconds).
        /// </param>
        /// <param name="id">
        /// The unique id assigned to the job.<br/>
        /// Example: a1b2c3d4e5
        /// </param>
        /// <param name="textName">
        /// Name of the text file submitted to be aligned to audio.
        /// </param>
        /// <param name="tracking">
        /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobInfo(
            global::System.DateTime createdAt,
            string dataName,
            int duration,
            string id,
            string? textName,
            global::G.TrackingData? tracking)
        {
            this.CreatedAt = createdAt;
            this.DataName = dataName ?? throw new global::System.ArgumentNullException(nameof(dataName));
            this.Duration = duration;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TextName = textName;
            this.Tracking = tracking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInfo" /> class.
        /// </summary>
        public JobInfo()
        {
        }
    }
}