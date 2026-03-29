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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpanKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanKind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<object>? Events { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<object>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanResource Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_request")]
        public global::G.LogRequest? LogRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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