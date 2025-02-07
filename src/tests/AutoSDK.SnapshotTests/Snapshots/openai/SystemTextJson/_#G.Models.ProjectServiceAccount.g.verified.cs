//HintName: G.Models.ProjectServiceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual service account in a project.
    /// </summary>
    public sealed partial class ProjectServiceAccount
    {
        /// <summary>
        /// The object type, which is always `organization.project.service_account`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectServiceAccountObjectJsonConverter))]
        public global::G.ProjectServiceAccountObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the service account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectServiceAccountRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectServiceAccountRole Role { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the service account was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccount" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.project.service_account`
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the service account
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the service account was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectServiceAccount(
            string id,
            string name,
            global::G.ProjectServiceAccountRole role,
            global::System.DateTimeOffset createdAt,
            global::G.ProjectServiceAccountObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.CreatedAt = createdAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccount" /> class.
        /// </summary>
        public ProjectServiceAccount()
        {
        }
    }
}