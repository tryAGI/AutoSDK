//HintName: G.Models.RenditionResponseAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The id and attributes of the generated rendition file.
    /// </summary>
    public sealed partial class RenditionResponseAttributes
    {
        /// <summary>
        /// The rendition id.<br/>
        /// Example: zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd
        /// </summary>
        /// <example>zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The status of the rendition transformation task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`waiting` - rendition task is waiting for source file to become available&lt;/li&gt;<br/>
        ///   &lt;li&gt;`queued` - rendition task is queued waiting to be processed&lt;/li&gt;<br/>
        ///   &lt;li&gt;`processing` - the rendition is being processed&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the rendition is ready to be downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error creating the rendition&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the rendition has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RenditionResponseAttributesStatusJsonConverter))]
        public global::G.RenditionResponseAttributesStatus? Status { get; set; }

        /// <summary>
        /// The URL of the rendition file hosted by Shotstack. The file at the URL can be used by the Edit API. Source file URL's consist of a base URL (AWS bucket), owner id, source id and a file name with the rendition id and extension.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd.mp4
        /// </summary>
        /// <example>https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The time in milliseconds it took to process the rendition.<br/>
        /// Example: 4120.36F
        /// </summary>
        /// <example>4120.36F</example>
        [global::Newtonsoft.Json.JsonProperty("executionTime")]
        public float? ExecutionTime { get; set; }

        /// <summary>
        /// A rendition is a new output file that is generated from the source. The rendition can be encoded to a different format and have transformations applied to it such as resizing, cropping, etc...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformation")]
        public global::G.Rendition? Transformation { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenditionResponseAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The rendition id.<br/>
        /// Example: zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd
        /// </param>
        /// <param name="status">
        /// The status of the rendition transformation task. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`waiting` - rendition task is waiting for source file to become available&lt;/li&gt;<br/>
        ///   &lt;li&gt;`queued` - rendition task is queued waiting to be processed&lt;/li&gt;<br/>
        ///   &lt;li&gt;`processing` - the rendition is being processed&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ready` - the rendition is ready to be downloaded&lt;/li&gt;<br/>
        ///   &lt;li&gt;`failed` - there was an error creating the rendition&lt;/li&gt;<br/>
        ///   &lt;li&gt;`deleted` - the rendition has been deleted&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: ready
        /// </param>
        /// <param name="url">
        /// The URL of the rendition file hosted by Shotstack. The file at the URL can be used by the Edit API. Source file URL's consist of a base URL (AWS bucket), owner id, source id and a file name with the rendition id and extension.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/zzyaqh5d-0jjq-va0n-aajo-3zwlje2q3uqd.mp4
        /// </param>
        /// <param name="executionTime">
        /// The time in milliseconds it took to process the rendition.<br/>
        /// Example: 4120.36F
        /// </param>
        /// <param name="transformation">
        /// A rendition is a new output file that is generated from the source. The rendition can be encoded to a different format and have transformations applied to it such as resizing, cropping, etc...
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
        public RenditionResponseAttributes(
            string id,
            global::G.RenditionResponseAttributesStatus? status,
            string? url,
            float? executionTime,
            global::G.Rendition? transformation,
            int? width,
            int? height,
            float? duration,
            float? fps)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Url = url;
            this.ExecutionTime = executionTime;
            this.Transformation = transformation;
            this.Width = width;
            this.Height = height;
            this.Duration = duration;
            this.Fps = fps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenditionResponseAttributes" /> class.
        /// </summary>
        public RenditionResponseAttributes()
        {
        }
    }
}