//HintName: G.Models.SelectedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SelectedActions
    {
        /// <summary>
        /// Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_owned_allowed")]
        public bool? GithubOwnedAllowed { get; set; }

        /// <summary>
        /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified_allowed")]
        public bool? VerifiedAllowed { get; set; }

        /// <summary>
        /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The `patterns_allowed` setting only applies to public repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("patterns_allowed")]
        public global::System.Collections.Generic.IList<string>? PatternsAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedActions" /> class.
        /// </summary>
        /// <param name="githubOwnedAllowed">
        /// Whether GitHub-owned actions are allowed. For example, this includes the actions in the `actions` organization.
        /// </param>
        /// <param name="verifiedAllowed">
        /// Whether actions from GitHub Marketplace verified creators are allowed. Set to `true` to allow all actions by GitHub Marketplace verified creators.
        /// </param>
        /// <param name="patternsAllowed">
        /// Specifies a list of string-matching patterns to allow specific action(s) and reusable workflow(s). Wildcards, tags, and SHAs are allowed. For example, `monalisa/octocat@*`, `monalisa/octocat@v2`, `monalisa/*`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The `patterns_allowed` setting only applies to public repositories.
        /// </param>
        public SelectedActions(
            bool? githubOwnedAllowed,
            bool? verifiedAllowed,
            global::System.Collections.Generic.IList<string>? patternsAllowed)
        {
            this.GithubOwnedAllowed = githubOwnedAllowed;
            this.VerifiedAllowed = verifiedAllowed;
            this.PatternsAllowed = patternsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectedActions" /> class.
        /// </summary>
        public SelectedActions()
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
        public static global::G.SelectedActions? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SelectedActions>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SelectedActions?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SelectedActions?>(serializer.Deserialize<global::G.SelectedActions>(jsonReader));
        }

    }
}