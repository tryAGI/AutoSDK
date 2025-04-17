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
        /// The size of the file, in bytes.<br/>
        /// Example: 13000
        /// </summary>
        /// <example>13000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.<br/>
        /// Example: 1716963433
        /// </summary>
        /// <example>1716963433</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The name of the uploaded file.<br/>
        /// Example: files_upload.jsonl
        /// </summary>
        /// <example>files_upload.jsonl</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The unique identifier of the file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </summary>
        /// <example>497f6eca-6276-4993-bfeb-53cbbbba6f09</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// The object type, which is always "file".<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilePurpose Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SampleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SampleType SampleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Source Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveFileOut" /> class.
        /// </summary>
        /// <param name="bytes">
        /// The size of the file, in bytes.<br/>
        /// Example: 13000
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) of the event.<br/>
        /// Example: 1716963433
        /// </param>
        /// <param name="deleted"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveFileOut(
            int bytes,
            global::System.DateTimeOffset createdAt,
            bool deleted,
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
            this.Deleted = deleted;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Id = id;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Purpose = purpose;
            this.SampleType = sampleType;
            this.Source = source;
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