//HintName: G.Models.CodeScanningVariantAnalysisRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository Identifier
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisRepository
    {
        /// <summary>
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269
        /// </summary>
        /// <example>1296269</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </summary>
        /// <example>Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// Whether the repository is private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StargazersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269
        /// </param>
        /// <param name="name">
        /// The name of the repository.<br/>
        /// Example: Hello-World
        /// </param>
        /// <param name="fullName">
        /// The full, globally unique, name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </param>
        /// <param name="private">
        /// Whether the repository is private.
        /// </param>
        /// <param name="stargazersCount">
        /// Example: 80
        /// </param>
        /// <param name="updatedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningVariantAnalysisRepository(
            int id,
            string name,
            string fullName,
            bool @private,
            int stargazersCount,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.Private = @private;
            this.StargazersCount = stargazersCount;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisRepository" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisRepository()
        {
        }
    }
}