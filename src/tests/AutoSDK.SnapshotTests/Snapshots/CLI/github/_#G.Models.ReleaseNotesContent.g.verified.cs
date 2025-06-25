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
        /// The generated name of the release<br/>
        /// Example: Release v1.0.0 is now available!
        /// </summary>
        /// <example>Release v1.0.0 is now available!</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseNotesContent" /> class.
        /// </summary>
        /// <param name="name">
        /// The generated name of the release<br/>
        /// Example: Release v1.0.0 is now available!
        /// </param>
        /// <param name="body">
        /// The generated body describing the contents of the release supporting markdown formatting
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReleaseNotesContent(
            string name,
            string body)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseNotesContent" /> class.
        /// </summary>
        public ReleaseNotesContent()
        {
        }
    }
}