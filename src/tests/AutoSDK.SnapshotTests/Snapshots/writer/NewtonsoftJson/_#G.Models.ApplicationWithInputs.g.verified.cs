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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Display name of the application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of no-code application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ApplicationType Type { get; set; }

        /// <summary>
        /// Current deployment status of the application. Note: currently only `deployed` applications are returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApplicationStatus Status { get; set; } = default!;

        /// <summary>
        /// List of input configurations for the application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApplicationInput> Inputs { get; set; } = default!;

        /// <summary>
        /// Timestamp when the application was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the application was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the application was last deployed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_deployed_at")]
        public global::System.DateTime? LastDeployedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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