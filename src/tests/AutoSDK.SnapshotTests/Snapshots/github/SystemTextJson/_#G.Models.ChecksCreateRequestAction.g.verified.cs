//HintName: G.Models.ChecksCreateRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequestAction
    {
        /// <summary>
        /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// A short explanation of what this action would do. The maximum size is 40 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A reference for the action on the integrator's system. The maximum size is 20 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestAction" /> class.
        /// </summary>
        /// <param name="label">
        /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
        /// </param>
        /// <param name="description">
        /// A short explanation of what this action would do. The maximum size is 40 characters.
        /// </param>
        /// <param name="identifier">
        /// A reference for the action on the integrator's system. The maximum size is 20 characters.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChecksCreateRequestAction(
            string label,
            string description,
            string identifier)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestAction" /> class.
        /// </summary>
        public ChecksCreateRequestAction()
        {
        }
    }
}