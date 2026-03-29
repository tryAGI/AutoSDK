//HintName: G.Models.SandboxEnvironmentVariableUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxEnvironmentVariableUpdate
    {
        /// <summary>
        /// The name of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// An optional description of the environment variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvironmentVariableUpdate" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the environment variable.
        /// </param>
        /// <param name="value">
        /// The value of the environment variable.
        /// </param>
        /// <param name="description">
        /// An optional description of the environment variable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxEnvironmentVariableUpdate(
            string? key,
            string? value,
            string? description)
        {
            this.Key = key;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvironmentVariableUpdate" /> class.
        /// </summary>
        public SandboxEnvironmentVariableUpdate()
        {
        }
    }
}