//HintName: G.Models.CodespaceExportDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An export of a codespace. Also, latest export details for a codespace can be fetched with id = latest
    /// </summary>
    public sealed partial class CodespaceExportDetails
    {
        /// <summary>
        /// State of the latest export<br/>
        /// Example: succeeded | failed | in_progress
        /// </summary>
        /// <example>succeeded | failed | in_progress</example>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Completion time of the last export operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Name of the exported branch<br/>
        /// Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        /// <example>codespace-monalisa-octocat-hello-world-g4wpq6h95q</example>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Git commit SHA of the exported branch<br/>
        /// Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </summary>
        /// <example>fd95a81ca01e48ede9f39c799ecbcef817b8a3b2</example>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Id for the export details<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Url for fetching export details<br/>
        /// Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </summary>
        /// <example>https://api.github.com/user/codespaces/:name/exports/latest</example>
        [global::Newtonsoft.Json.JsonProperty("export_url")]
        public string? ExportUrl { get; set; }

        /// <summary>
        /// Web url for the exported branch<br/>
        /// Example: https://github.com/octocat/hello-world/tree/:branch
        /// </summary>
        /// <example>https://github.com/octocat/hello-world/tree/:branch</example>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceExportDetails" /> class.
        /// </summary>
        /// <param name="state">
        /// State of the latest export<br/>
        /// Example: succeeded | failed | in_progress
        /// </param>
        /// <param name="completedAt">
        /// Completion time of the last export operation
        /// </param>
        /// <param name="branch">
        /// Name of the exported branch<br/>
        /// Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </param>
        /// <param name="sha">
        /// Git commit SHA of the exported branch<br/>
        /// Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </param>
        /// <param name="id">
        /// Id for the export details<br/>
        /// Example: latest
        /// </param>
        /// <param name="exportUrl">
        /// Url for fetching export details<br/>
        /// Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </param>
        /// <param name="htmlUrl">
        /// Web url for the exported branch<br/>
        /// Example: https://github.com/octocat/hello-world/tree/:branch
        /// </param>
        public CodespaceExportDetails(
            string? state,
            global::System.DateTime? completedAt,
            string? branch,
            string? sha,
            string? id,
            string? exportUrl,
            string? htmlUrl)
        {
            this.State = state;
            this.CompletedAt = completedAt;
            this.Branch = branch;
            this.Sha = sha;
            this.Id = id;
            this.ExportUrl = exportUrl;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceExportDetails" /> class.
        /// </summary>
        public CodespaceExportDetails()
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
        public static global::G.CodespaceExportDetails? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodespaceExportDetails>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespaceExportDetails?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodespaceExportDetails?>(serializer.Deserialize<global::G.CodespaceExportDetails>(jsonReader));
        }

    }
}