//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_generation")]
        public string? FailedGeneration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_path")]
        public string? SchemaPath { get; set; }

        /// <summary>
        /// Segments of the schema path relevant to validation errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_path_segments")]
        public global::System.Collections.Generic.IList<string>? SchemaPathSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_kind")]
        public string? SchemaKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_code")]
        public string? SchemaCode { get; set; }

        /// <summary>
        /// Debug information including input and output token IDs and strings. Only present when debug=true in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug")]
        public global::G.DebugData? Debug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <param name="code"></param>
        /// <param name="failedGeneration"></param>
        /// <param name="schemaPath"></param>
        /// <param name="schemaPathSegments">
        /// Segments of the schema path relevant to validation errors.
        /// </param>
        /// <param name="schemaKind"></param>
        /// <param name="schemaCode"></param>
        /// <param name="debug">
        /// Debug information including input and output token IDs and strings. Only present when debug=true in the request.
        /// </param>
        public Error(
            string message,
            string type,
            string? param,
            string? code,
            string? failedGeneration,
            string? schemaPath,
            global::System.Collections.Generic.IList<string>? schemaPathSegments,
            string? schemaKind,
            string? schemaCode,
            global::G.DebugData? debug)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Param = param;
            this.Code = code;
            this.FailedGeneration = failedGeneration;
            this.SchemaPath = schemaPath;
            this.SchemaPathSegments = schemaPathSegments;
            this.SchemaKind = schemaKind;
            this.SchemaCode = schemaCode;
            this.Debug = debug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}