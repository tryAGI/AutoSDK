//HintName: G.Models.UserExtensionComponentUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtensionComponentUpdate
    {
        /// <summary>
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured a component extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The extension’s version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The x-coordinate where the extension is placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public int? X { get; set; }

        /// <summary>
        /// The y-coordinate where the extension is placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public int? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionComponentUpdate" /> class.
        /// </summary>
        /// <param name="active">
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured a component extension.
        /// </param>
        /// <param name="id">
        /// An ID that identifies the extension.
        /// </param>
        /// <param name="version">
        /// The extension’s version.
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the extension is placed.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the extension is placed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserExtensionComponentUpdate(
            bool active,
            string? id,
            string? version,
            int? x,
            int? y)
        {
            this.Active = active;
            this.Id = id;
            this.Version = version;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionComponentUpdate" /> class.
        /// </summary>
        public UserExtensionComponentUpdate()
        {
        }
    }
}