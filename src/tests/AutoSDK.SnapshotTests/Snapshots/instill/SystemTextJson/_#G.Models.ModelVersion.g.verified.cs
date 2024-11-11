//HintName: G.Models.ModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ModelVersion contains information about the version of a model.
    /// </summary>
    public sealed partial class ModelVersion
    {
        /// <summary>
        /// The parent resource, i.e., the user that created the models.<br/>
        /// - Format: `users/{user.id}`.<br/>
        /// The resource name of the model, which allows its access by parent user<br/>
        /// and ID.<br/>
        /// - Format: `users/{user.id}/models/{model.id}`.<br/>
        /// The name of the Version.<br/>
        /// - Format: `users/{user.id}/models/{model.id}/versions/{version.id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The model version identifier, which is equal to image tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Unique identifier, computed from the manifest the Version refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Current state of this model version.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StateJsonConverter))]
        public global::G.State? State { get; set; }

        /// <summary>
        /// Version update time, i.e. timestamp of the last push.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersion" /> class.
        /// </summary>
        /// <param name="name">
        /// The parent resource, i.e., the user that created the models.<br/>
        /// - Format: `users/{user.id}`.<br/>
        /// The resource name of the model, which allows its access by parent user<br/>
        /// and ID.<br/>
        /// - Format: `users/{user.id}/models/{model.id}`.<br/>
        /// The name of the Version.<br/>
        /// - Format: `users/{user.id}/models/{model.id}/versions/{version.id}`.
        /// </param>
        /// <param name="version">
        /// The model version identifier, which is equal to image tag.
        /// </param>
        /// <param name="digest">
        /// Unique identifier, computed from the manifest the Version refers to.
        /// </param>
        /// <param name="state">
        /// Current state of this model version.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Version update time, i.e. timestamp of the last push.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelVersion(
            string? name,
            string? version,
            string? digest,
            global::G.State? state,
            global::System.DateTime? updateTime)
        {
            this.Name = name;
            this.Version = version;
            this.Digest = digest;
            this.State = state;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersion" /> class.
        /// </summary>
        public ModelVersion()
        {
        }
    }
}