//HintName: G.Models.Trace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Trace
    {
        /// <summary>
        /// The unique identifier of a trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The timestamp when the trace was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// The name of the trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The input data of the trace. Can be any JSON.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The output data of the trace. Can be any JSON.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The session identifier associated with the trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The release version of the application when the trace was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release")]
        public string? Release { get; set; }

        /// <summary>
        /// The version of the trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The user identifier associated with the trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The metadata associated with the trace. Can be any JSON.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tags associated with the trace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Public traces are accessible via url without login
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// The environment from which this trace originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Environment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of a trace
        /// </param>
        /// <param name="timestamp">
        /// The timestamp when the trace was created
        /// </param>
        /// <param name="tags">
        /// The tags associated with the trace.
        /// </param>
        /// <param name="public">
        /// Public traces are accessible via url without login
        /// </param>
        /// <param name="environment">
        /// The environment from which this trace originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="name">
        /// The name of the trace
        /// </param>
        /// <param name="input">
        /// The input data of the trace. Can be any JSON.
        /// </param>
        /// <param name="output">
        /// The output data of the trace. Can be any JSON.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier associated with the trace
        /// </param>
        /// <param name="release">
        /// The release version of the application when the trace was created
        /// </param>
        /// <param name="version">
        /// The version of the trace
        /// </param>
        /// <param name="userId">
        /// The user identifier associated with the trace
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the trace. Can be any JSON.
        /// </param>
        public Trace(
            string id,
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<string> tags,
            bool @public,
            string environment,
            string? name,
            object? input,
            object? output,
            string? sessionId,
            string? release,
            string? version,
            string? userId,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp;
            this.Name = name;
            this.Input = input;
            this.Output = output;
            this.SessionId = sessionId;
            this.Release = release;
            this.Version = version;
            this.UserId = userId;
            this.Metadata = metadata;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Public = @public;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        public Trace()
        {
        }
    }
}