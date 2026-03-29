//HintName: G.Models.UploadDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadDatasetRequestActionJsonConverter))]
        public global::G.UploadDatasetRequestAction? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<object>? Metadata { get; set; }

        /// <summary>
        /// Split per example: string, string array, or null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, global::System.Collections.Generic.IList<string>, object>>? Splits { get; set; }

        /// <summary>
        /// Span IDs to link examples back to spans
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_ids")]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, object>>? SpanIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="action"></param>
        /// <param name="description"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="splits">
        /// Split per example: string, string array, or null
        /// </param>
        /// <param name="spanIds">
        /// Span IDs to link examples back to spans
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetRequest(
            string name,
            global::System.Collections.Generic.IList<object> inputs,
            global::G.UploadDatasetRequestAction? action,
            string? description,
            global::System.Collections.Generic.IList<object>? outputs,
            global::System.Collections.Generic.IList<object>? metadata,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::System.Collections.Generic.IList<string>, object>>? splits,
            global::System.Collections.Generic.IList<global::G.OneOf<string, object>>? spanIds)
        {
            this.Action = action;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs;
            this.Metadata = metadata;
            this.Splits = splits;
            this.SpanIds = spanIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetRequest" /> class.
        /// </summary>
        public UploadDatasetRequest()
        {
        }
    }
}