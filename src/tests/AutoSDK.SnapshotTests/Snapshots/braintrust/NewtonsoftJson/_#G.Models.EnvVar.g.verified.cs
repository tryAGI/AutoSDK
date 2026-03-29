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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The type of the object the environment variable is scoped for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnvVarObjectType2 ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the object the environment variable is scoped for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// The name of the environment variable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Date of environment variable creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date the environment variable was last used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used")]
        public global::System.DateTime? Used { get; set; }

        /// <summary>
        /// Optional metadata associated with the environment variable when managed via the function secrets API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Optional classification for the secret (for example, the AI provider name)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_type")]
        public string? SecretType { get; set; }

        /// <summary>
        /// The category of the secret: env_var for regular environment variables, ai_provider for AI provider API keys<br/>
        /// Default Value: env_var
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_category")]
        public global::G.EnvVarSecretCategory? SecretCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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