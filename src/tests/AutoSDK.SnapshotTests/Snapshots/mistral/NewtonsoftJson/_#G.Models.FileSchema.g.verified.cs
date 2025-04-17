//HintName: G.Models.FileSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSchema
    {
        /// <summary>
        /// The size of the file, in bytes.<br/>
        /// Example: 13000
        /// </summary>
        /// <example>13000</example>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.<br/>
        /// Example: 1716963433
        /// </summary>
        /// <example>1716963433</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the uploaded file.<br/>
        /// Example: files_upload.jsonl
        /// </summary>
        /// <example>files_upload.jsonl</example>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </summary>
        /// <example>497f6eca-6276-4993-bfeb-53cbbbba6f09</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// The object type, which is always "file".<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SampleType SampleType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchema" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The size of the file, in bytes.<br/>
        /// Example: 13000
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) of the event.<br/>
        /// Example: 1716963433
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file.<br/>
        /// Example: files_upload.jsonl
        /// </param>
        /// <param name="id">
        /// The unique identifier of the file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </param>
        /// <param name="numLines"></param>
        /// <param name="object">
        /// The object type, which is always "file".<br/>
        /// Example: file
        /// </param>
        /// <param name="purpose"></param>
        /// <param name="sampleType"></param>
        /// <param name="source"></param>
        public FileSchema(
            int bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            global::System.Guid id,
            string @object,
            global::G.FilePurpose purpose,
            global::G.SampleType sampleType,
            global::G.Source source,
            int? numLines)
        {
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Purpose = purpose;
            this.SampleType = sampleType;
            this.Source = source;
            this.NumLines = numLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchema" /> class.
        /// </summary>
        public FileSchema()
        {
        }
    }
}