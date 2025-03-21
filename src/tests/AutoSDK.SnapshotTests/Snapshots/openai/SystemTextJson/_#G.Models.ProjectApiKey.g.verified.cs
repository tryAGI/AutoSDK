//HintName: G.Models.ProjectApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual API key in a project.
    /// </summary>
    public sealed partial class ProjectApiKey
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The object type, which is always `organization.project.api_key`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectApiKeyObjectJsonConverter))]
        public global::G.ProjectApiKeyObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectApiKeyOwner Owner { get; set; }

        /// <summary>
        /// The redacted value of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKey" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the API key was created
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the API key
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.api_key`
        /// </param>
        /// <param name="owner"></param>
        /// <param name="redactedValue">
        /// The redacted value of the API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectApiKey(
            global::System.DateTimeOffset createdAt,
            string id,
            string name,
            global::G.ProjectApiKeyOwner owner,
            string redactedValue,
            global::G.ProjectApiKeyObject @object)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.RedactedValue = redactedValue ?? throw new global::System.ArgumentNullException(nameof(redactedValue));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKey" /> class.
        /// </summary>
        public ProjectApiKey()
        {
        }
    }
}