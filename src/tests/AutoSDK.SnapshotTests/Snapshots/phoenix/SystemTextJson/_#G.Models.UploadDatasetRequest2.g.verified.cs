//HintName: G.Models.UploadDatasetRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadDatasetRequestAction2JsonConverter))]
        public global::G.UploadDatasetRequestAction2? Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_keys[]")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_keys[]")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_keys[]")]
        public global::System.Collections.Generic.IList<string>? MetadataKeys { get; set; }

        /// <summary>
        /// Column names for auto-assigning examples to splits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_keys[]")]
        public global::System.Collections.Generic.IList<string>? SplitKeys { get; set; }

        /// <summary>
        /// Column names whose object values should be flattened into their selected bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_keys[]")]
        public global::System.Collections.Generic.IList<string>? FlattenKeys { get; set; }

        /// <summary>
        /// Column name for span IDs to link examples back to spans
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id_key")]
        public string? SpanIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetRequest2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="action"></param>
        /// <param name="description"></param>
        /// <param name="metadataKeys"></param>
        /// <param name="splitKeys">
        /// Column names for auto-assigning examples to splits
        /// </param>
        /// <param name="flattenKeys">
        /// Column names whose object values should be flattened into their selected bucket
        /// </param>
        /// <param name="spanIdKey">
        /// Column name for span IDs to link examples back to spans
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetRequest2(
            string name,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.Collections.Generic.IList<string> outputKeys,
            byte[] file,
            string filename,
            global::G.UploadDatasetRequestAction2? action,
            string? description,
            global::System.Collections.Generic.IList<string>? metadataKeys,
            global::System.Collections.Generic.IList<string>? splitKeys,
            global::System.Collections.Generic.IList<string>? flattenKeys,
            string? spanIdKey)
        {
            this.Action = action;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.InputKeys = inputKeys ?? throw new global::System.ArgumentNullException(nameof(inputKeys));
            this.OutputKeys = outputKeys ?? throw new global::System.ArgumentNullException(nameof(outputKeys));
            this.MetadataKeys = metadataKeys;
            this.SplitKeys = splitKeys;
            this.FlattenKeys = flattenKeys;
            this.SpanIdKey = spanIdKey;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetRequest2" /> class.
        /// </summary>
        public UploadDatasetRequest2()
        {
        }
    }
}