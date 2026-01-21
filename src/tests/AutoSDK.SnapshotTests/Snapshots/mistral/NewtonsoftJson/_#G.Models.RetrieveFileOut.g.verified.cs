//HintName: G.Models.RetrieveFileOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveFileOut
    {
        /// <summary>
        /// The unique identifier of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "file".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the uploaded file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.
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
        [global::Newtonsoft.Json.JsonProperty("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveFileOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "file".
        /// </param>
        /// <param name="bytes">
        /// The size of the file, in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) of the event.
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file. Only accepts fine-tuning (`fine-tune`) for now.
        /// </param>
        /// <param name="sampleType"></param>
        /// <param name="numLines"></param>
        /// <param name="source"></param>
        /// <param name="deleted"></param>
        public RetrieveFileOut(
            global::System.Guid id,
            string @object,
            int bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            global::G.FilePurpose purpose,
            global::G.SampleType sampleType,
            global::G.Source source,
            bool deleted,
            int? numLines)
        {
            this.Id = id;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.SampleType = sampleType;
            this.Source = source;
            this.Deleted = deleted;
            this.NumLines = numLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveFileOut" /> class.
        /// </summary>
        public RetrieveFileOut()
        {
        }
    }
}