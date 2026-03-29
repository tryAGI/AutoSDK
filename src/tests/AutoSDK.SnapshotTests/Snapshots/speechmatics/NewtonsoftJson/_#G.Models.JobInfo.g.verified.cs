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
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Name of data file submitted for job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataName { get; set; } = default!;

        /// <summary>
        /// The data file audio duration (in seconds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The unique id assigned to the job.<br/>
        /// Example: a1b2c3d4e5
        /// </summary>
        /// <example>a1b2c3d4e5</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the text file submitted to be aligned to audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_name")]
        public string? TextName { get; set; }

        /// <summary>
        /// Example: {"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}
        /// </summary>
        /// <example>{"title":"ACME Q12018 Earnings Call","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}</example>
        [global::Newtonsoft.Json.JsonProperty("tracking")]
        public global::G.TrackingData? Tracking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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