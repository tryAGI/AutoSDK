//HintName: G.Models.Span.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Span
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanContext Context { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SpanKindJsonConverter))]
        public global::G.SpanKind Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public object Attributes { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<object>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanResource Resource { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_request")]
        public global::G.LogRequest? LogRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Span" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="context"></param>
        /// <param name="kind"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="status"></param>
        /// <param name="attributes"></param>
        /// <param name="resource"></param>
        /// <param name="parentId"></param>
        /// <param name="events">
        /// Default Value: []
        /// </param>
        /// <param name="links">
        /// Default Value: []
        /// </param>
        /// <param name="logRequest"></param>
        public Span(
            string name,
            global::G.SpanContext context,
            global::G.SpanKind kind,
            int startTime,
            int endTime,
            global::G.SpanStatus status,
            object attributes,
            global::G.SpanResource resource,
            string? parentId,
            global::System.Collections.Generic.IList<object>? events,
            global::System.Collections.Generic.IList<object>? links,
            global::G.LogRequest? logRequest)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Kind = kind;
            this.ParentId = parentId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Events = events;
            this.Links = links;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.LogRequest = logRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Span" /> class.
        /// </summary>
        public Span()
        {
        }
    }
}