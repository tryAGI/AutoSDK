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

    }
}