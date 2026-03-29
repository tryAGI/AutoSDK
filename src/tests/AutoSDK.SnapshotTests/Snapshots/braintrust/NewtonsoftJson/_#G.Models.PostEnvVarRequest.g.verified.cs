//HintName: G.Models.PostEnvVarRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostEnvVarRequest
    {
        /// <summary>
        /// The type of the object the environment variable is scoped for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostEnvVarRequestObjectType ObjectType { get; set; } = default!;

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
        /// The value of the environment variable. Will be encrypted at rest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostEnvVarRequest" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The type of the object the environment variable is scoped for
        /// </param>
        /// <param name="objectId">
        /// The id of the object the environment variable is scoped for
        /// </param>
        /// <param name="name">
        /// The name of the environment variable
        /// </param>
        /// <param name="value">
        /// The value of the environment variable. Will be encrypted at rest.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the environment variable when managed via the function secrets API
        /// </param>
        /// <param name="secretType">
        /// Optional classification for the secret (for example, the AI provider name)
        /// </param>
        public PostEnvVarRequest(
            global::G.PostEnvVarRequestObjectType objectType,
            global::System.Guid objectId,
            string name,
            string? value,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            string? secretType)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.Metadata = metadata;
            this.SecretType = secretType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostEnvVarRequest" /> class.
        /// </summary>
        public PostEnvVarRequest()
        {
        }
    }
}