//HintName: G.Models.EnvVar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvVar
    {
        /// <summary>
        /// Unique identifier for the environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The type of the object the environment variable is scoped for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvVarObjectType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnvVarObjectType2 ObjectType { get; set; }

        /// <summary>
        /// The id of the object the environment variable is scoped for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// The name of the environment variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Date of environment variable creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date the environment variable was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public global::System.DateTime? Used { get; set; }

        /// <summary>
        /// Optional metadata associated with the environment variable when managed via the function secrets API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Optional classification for the secret (for example, the AI provider name)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_type")]
        public string? SecretType { get; set; }

        /// <summary>
        /// The category of the secret: env_var for regular environment variables, ai_provider for AI provider API keys<br/>
        /// Default Value: env_var
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvVarSecretCategoryJsonConverter))]
        public global::G.EnvVarSecretCategory? SecretCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the environment variable
        /// </param>
        /// <param name="objectType">
        /// The type of the object the environment variable is scoped for
        /// </param>
        /// <param name="objectId">
        /// The id of the object the environment variable is scoped for
        /// </param>
        /// <param name="name">
        /// The name of the environment variable
        /// </param>
        /// <param name="created">
        /// Date of environment variable creation
        /// </param>
        /// <param name="used">
        /// Date the environment variable was last used
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the environment variable when managed via the function secrets API
        /// </param>
        /// <param name="secretType">
        /// Optional classification for the secret (for example, the AI provider name)
        /// </param>
        /// <param name="secretCategory">
        /// The category of the secret: env_var for regular environment variables, ai_provider for AI provider API keys<br/>
        /// Default Value: env_var
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvVar(
            global::System.Guid id,
            global::G.EnvVarObjectType2 objectType,
            global::System.Guid objectId,
            string name,
            global::System.DateTime? created,
            global::System.DateTime? used,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            string? secretType,
            global::G.EnvVarSecretCategory? secretCategory)
        {
            this.Id = id;
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Used = used;
            this.Metadata = metadata;
            this.SecretType = secretType;
            this.SecretCategory = secretCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVar" /> class.
        /// </summary>
        public EnvVar()
        {
        }
    }
}