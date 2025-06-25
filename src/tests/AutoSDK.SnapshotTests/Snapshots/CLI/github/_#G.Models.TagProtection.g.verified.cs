//HintName: G.Models.TagProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tag protection
    /// </summary>
    public sealed partial class TagProtection
    {
        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:01:12Z
        /// </summary>
        /// <example>2011-01-26T19:01:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:01:12Z
        /// </summary>
        /// <example>2011-01-26T19:01:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Example: v1.*
        /// </summary>
        /// <example>v1.*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagProtection" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 2
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-01-26T19:01:12Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2011-01-26T19:01:12Z
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="pattern">
        /// Example: v1.*
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagProtection(
            string pattern,
            int? id,
            string? createdAt,
            string? updatedAt,
            bool? enabled)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagProtection" /> class.
        /// </summary>
        public TagProtection()
        {
        }
    }
}