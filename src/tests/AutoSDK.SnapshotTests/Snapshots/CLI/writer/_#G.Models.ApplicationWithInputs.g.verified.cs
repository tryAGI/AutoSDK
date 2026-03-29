//HintName: G.Models.ApplicationWithInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed application object including its input configuration.
    /// </summary>
    public sealed partial class ApplicationWithInputs
    {
        /// <summary>
        /// Unique identifier for the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name of the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of no-code application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApplicationTypeJsonConverter))]
        public global::G.ApplicationType Type { get; set; }

        /// <summary>
        /// Current deployment status of the application. Note: currently only `deployed` applications are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApplicationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApplicationStatus Status { get; set; }

        /// <summary>
        /// List of input configurations for the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ApplicationInput> Inputs { get; set; }

        /// <summary>
        /// Timestamp when the application was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the application was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp when the application was last deployed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_at")]
        public global::System.DateTime? LastDeployedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationWithInputs" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the application.
        /// </param>
        /// <param name="name">
        /// Display name of the application.
        /// </param>
        /// <param name="status">
        /// Current deployment status of the application. Note: currently only `deployed` applications are returned.
        /// </param>
        /// <param name="inputs">
        /// List of input configurations for the application.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the application was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the application was last updated.
        /// </param>
        /// <param name="type">
        /// The type of no-code application.
        /// </param>
        /// <param name="lastDeployedAt">
        /// Timestamp when the application was last deployed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationWithInputs(
            global::System.Guid id,
            string name,
            global::G.ApplicationStatus status,
            global::System.Collections.Generic.IList<global::G.ApplicationInput> inputs,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ApplicationType type,
            global::System.DateTime? lastDeployedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Status = status;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastDeployedAt = lastDeployedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationWithInputs" /> class.
        /// </summary>
        public ApplicationWithInputs()
        {
        }
    }
}