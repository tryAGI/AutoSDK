//HintName: G.Models.ReleaseNotesContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generated name and body describing a release
    /// </summary>
    public sealed partial class ReleaseNotesContent
    {
        /// <summary>
        /// The generated name of the release
        /// <br/>Example: Release v1.0.0 is now available!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The generated body describing the contents of the release supporting markdown formatting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}