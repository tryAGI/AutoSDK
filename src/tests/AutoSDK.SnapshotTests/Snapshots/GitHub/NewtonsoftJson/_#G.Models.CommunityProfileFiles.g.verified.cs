//HintName: G.Models.CommunityProfileFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommunityProfileFiles
    {
        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_of_conduct", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCodeOfConductSimple? CodeOfConduct { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_of_conduct_file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCommunityHealthFile? CodeOfConductFile { get; set; } = default!;

        /// <summary>
        /// License Simple
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableLicenseSimple? License { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCommunityHealthFile? Contributing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCommunityHealthFile? Readme { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCommunityHealthFile? IssueTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCommunityHealthFile? PullRequestTemplate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        /// <param name="codeOfConduct">
        /// Code of Conduct Simple
        /// </param>
        /// <param name="codeOfConductFile"></param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="contributing"></param>
        /// <param name="readme"></param>
        /// <param name="issueTemplate"></param>
        /// <param name="pullRequestTemplate"></param>
        public CommunityProfileFiles(
            global::G.NullableCodeOfConductSimple? codeOfConduct,
            global::G.NullableCommunityHealthFile? codeOfConductFile,
            global::G.NullableLicenseSimple? license,
            global::G.NullableCommunityHealthFile? contributing,
            global::G.NullableCommunityHealthFile? readme,
            global::G.NullableCommunityHealthFile? issueTemplate,
            global::G.NullableCommunityHealthFile? pullRequestTemplate)
        {
            this.CodeOfConduct = codeOfConduct ?? throw new global::System.ArgumentNullException(nameof(codeOfConduct));
            this.CodeOfConductFile = codeOfConductFile ?? throw new global::System.ArgumentNullException(nameof(codeOfConductFile));
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.Contributing = contributing ?? throw new global::System.ArgumentNullException(nameof(contributing));
            this.Readme = readme ?? throw new global::System.ArgumentNullException(nameof(readme));
            this.IssueTemplate = issueTemplate ?? throw new global::System.ArgumentNullException(nameof(issueTemplate));
            this.PullRequestTemplate = pullRequestTemplate ?? throw new global::System.ArgumentNullException(nameof(pullRequestTemplate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        public CommunityProfileFiles()
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
        public static global::G.CommunityProfileFiles? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CommunityProfileFiles>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CommunityProfileFiles?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CommunityProfileFiles?>(serializer.Deserialize<global::G.CommunityProfileFiles>(jsonReader));
        }

    }
}