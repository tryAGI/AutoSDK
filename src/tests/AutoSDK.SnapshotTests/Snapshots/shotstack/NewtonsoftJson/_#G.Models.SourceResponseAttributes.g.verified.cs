//HintName: G.Models.SourceResponseAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The id and attributes of the source file.
    /// </summary>
    public sealed partial class SourceResponseAttributes
    {
        /// <summary>
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </summary>
        /// <example>zzytey4v-32km-kq1z-aftr-3kcuqi0brad2</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The owner id of the source file.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// The original URL of an ingested source file, where it originated. Only displayed for files ingested using the [fetch source](#fetch-source) endpoint. Not displayed for direct uploads.<br/>
        /// Example: https://github.com/shotstack/test-media/raw/main/captioning/scott-ko.mp4
        /// </summary>
        /// <example>https://github.com/shotstack/test-media/raw/main/captioning/scott-ko.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The URL of the source file hosted by Shotstack. The file at the URL can be used by the Edit API. Source file URL's consist of a base URL (AWS bucket), owner id, source id and a file named source. The extension varies depending on the type of file ingested.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source.mp4
        /// </summary>
        /// <example>https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The status of the source file ingestion task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - ingestion task is queued waiting to be fetched&lt;/li&gt;<br/>
        ///   &lt;li&gt;`importing` - the source file is being downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the source file has been ingested and stored&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error ingesting the source file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the source file has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.SourceResponseAttributesStatus? Status { get; set; }

        /// <summary>
        /// The list of outputs generated from the source file. Currently supports renditions which are versions of the source file with different transformations applied.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.OutputsResponse? Outputs { get; set; }

        /// <summary>
        /// The width in pixels of the ingested source file, if a video or image.<br/>
        /// Example: 1920
        /// </summary>
        /// <example>1920</example>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height in pixels of the ingested source file, if a video or image.<br/>
        /// Example: 1080
        /// </summary>
        /// <example>1080</example>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The duration in seconds of the ingested source file, if a video or audio file.<br/>
        /// Example: 25.86F
        /// </summary>
        /// <example>25.86F</example>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// The frame rate in frames per second of the source file, if a video file.<br/>
        /// Example: 23.967F
        /// </summary>
        /// <example>23.967F</example>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public float? Fps { get; set; }

        /// <summary>
        /// The time the ingestion task was initially queued.<br/>
        /// Example: 2023-01-02T01:47:18.973Z
        /// </summary>
        /// <example>2023-01-02T01:47:18.973Z</example>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// The time the ingestion status was last updated.<br/>
        /// Example: 2023-01-02T01:47:37.260Z
        /// </summary>
        /// <example>2023-01-02T01:47:37.260Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceResponseAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </param>
        /// <param name="owner">
        /// The owner id of the source file.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="input">
        /// The original URL of an ingested source file, where it originated. Only displayed for files ingested using the [fetch source](#fetch-source) endpoint. Not displayed for direct uploads.<br/>
        /// Example: https://github.com/shotstack/test-media/raw/main/captioning/scott-ko.mp4
        /// </param>
        /// <param name="source">
        /// The URL of the source file hosted by Shotstack. The file at the URL can be used by the Edit API. Source file URL's consist of a base URL (AWS bucket), owner id, source id and a file named source. The extension varies depending on the type of file ingested.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source.mp4
        /// </param>
        /// <param name="status">
        /// The status of the source file ingestion task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`queued` - ingestion task is queued waiting to be fetched&lt;/li&gt;<br/>
        ///   &lt;li&gt;`importing` - the source file is being downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the source file has been ingested and stored&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error ingesting the source file&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the source file has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </param>
        /// <param name="outputs">
        /// The list of outputs generated from the source file. Currently supports renditions which are versions of the source file with different transformations applied.
        /// </param>
        /// <param name="width">
        /// The width in pixels of the ingested source file, if a video or image.<br/>
        /// Example: 1920
        /// </param>
        /// <param name="height">
        /// The height in pixels of the ingested source file, if a video or image.<br/>
        /// Example: 1080
        /// </param>
        /// <param name="duration">
        /// The duration in seconds of the ingested source file, if a video or audio file.<br/>
        /// Example: 25.86F
        /// </param>
        /// <param name="fps">
        /// The frame rate in frames per second of the source file, if a video file.<br/>
        /// Example: 23.967F
        /// </param>
        /// <param name="created">
        /// The time the ingestion task was initially queued.<br/>
        /// Example: 2023-01-02T01:47:18.973Z
        /// </param>
        /// <param name="updated">
        /// The time the ingestion status was last updated.<br/>
        /// Example: 2023-01-02T01:47:37.260Z
        /// </param>
        public SourceResponseAttributes(
            string id,
            string owner,
            string? input,
            string? source,
            global::G.SourceResponseAttributesStatus? status,
            global::G.OutputsResponse? outputs,
            int? width,
            int? height,
            float? duration,
            float? fps,
            string? created,
            string? updated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Input = input;
            this.Source = source;
            this.Status = status;
            this.Outputs = outputs;
            this.Width = width;
            this.Height = height;
            this.Duration = duration;
            this.Fps = fps;
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceResponseAttributes" /> class.
        /// </summary>
        public SourceResponseAttributes()
        {
        }
    }
}