//HintName: G.Models.BranchWithProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch With Protection
    /// </summary>
    public sealed partial class BranchWithProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BranchWithProtectionLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// Branch Protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BranchProtection Protection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProtectionUrl { get; set; }

        /// <summary>
        /// Example: "mas*"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        public int? RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchWithProtection" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit">
        /// Commit
        /// </param>
        /// <param name="links"></param>
        /// <param name="protected"></param>
        /// <param name="protection">
        /// Branch Protection
        /// </param>
        /// <param name="protectionUrl"></param>
        /// <param name="pattern">
        /// Example: "mas*"
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// Example: 1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BranchWithProtection(
            string name,
            global::G.Commit commit,
            global::G.BranchWithProtectionLinks links,
            bool @protected,
            global::G.BranchProtection protection,
            string protectionUrl,
            string? pattern,
            int? requiredApprovingReviewCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Protected = @protected;
            this.Protection = protection ?? throw new global::System.ArgumentNullException(nameof(protection));
            this.ProtectionUrl = protectionUrl ?? throw new global::System.ArgumentNullException(nameof(protectionUrl));
            this.Pattern = pattern;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchWithProtection" /> class.
        /// </summary>
        public BranchWithProtection()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.BranchWithProtection? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BranchWithProtection),
                jsonSerializerContext) as global::G.BranchWithProtection;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BranchWithProtection? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BranchWithProtection>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.BranchWithProtection?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.BranchWithProtection),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.BranchWithProtection;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.BranchWithProtection?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.BranchWithProtection?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}