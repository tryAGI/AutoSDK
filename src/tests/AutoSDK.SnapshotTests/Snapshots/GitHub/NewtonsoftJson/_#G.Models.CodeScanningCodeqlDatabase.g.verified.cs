//HintName: G.Models.CodeScanningCodeqlDatabase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CodeQL database.
    /// </summary>
    public sealed partial class CodeScanningCodeqlDatabase
    {
        /// <summary>
        /// The ID of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The language of the CodeQL database.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploader", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Uploader { get; set; } = default!;

        /// <summary>
        /// The MIME type of the CodeQL database file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// The size of the CodeQL database file in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// The date and time at which the CodeQL database was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The date and time at which the CodeQL database was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The commit SHA of the repository at the time the CodeQL database was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_oid")]
        public string? CommitOid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCodeqlDatabase" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the CodeQL database.
        /// </param>
        /// <param name="name">
        /// The name of the CodeQL database.
        /// </param>
        /// <param name="language">
        /// The language of the CodeQL database.
        /// </param>
        /// <param name="uploader">
        /// A GitHub user.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the CodeQL database file.
        /// </param>
        /// <param name="size">
        /// The size of the CodeQL database file in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The date and time at which the CodeQL database was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time at which the CodeQL database was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="url">
        /// The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.
        /// </param>
        /// <param name="commitOid">
        /// The commit SHA of the repository at the time the CodeQL database was created.
        /// </param>
        public CodeScanningCodeqlDatabase(
            int id,
            string name,
            string language,
            global::G.SimpleUser uploader,
            string contentType,
            int size,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string url,
            string? commitOid)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Uploader = uploader ?? throw new global::System.ArgumentNullException(nameof(uploader));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CommitOid = commitOid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningCodeqlDatabase" /> class.
        /// </summary>
        public CodeScanningCodeqlDatabase()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodeScanningCodeqlDatabase? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningCodeqlDatabase>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningCodeqlDatabase?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningCodeqlDatabase?>(serializer.Deserialize<global::G.CodeScanningCodeqlDatabase>(jsonReader));
        }

    }
}