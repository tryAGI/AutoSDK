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
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.UploadDatasetRequestAction2? Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_keys[]", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> InputKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_keys[]", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> OutputKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_keys[]")]
        public global::System.Collections.Generic.IList<string>? MetadataKeys { get; set; }

        /// <summary>
        /// Column names for auto-assigning examples to splits
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("split_keys[]")]
        public global::System.Collections.Generic.IList<string>? SplitKeys { get; set; }

        /// <summary>
        /// Column names whose object values should be flattened into their selected bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flatten_keys[]")]
        public global::System.Collections.Generic.IList<string>? FlattenKeys { get; set; }

        /// <summary>
        /// Column name for span IDs to link examples back to spans
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id_key")]
        public string? SpanIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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