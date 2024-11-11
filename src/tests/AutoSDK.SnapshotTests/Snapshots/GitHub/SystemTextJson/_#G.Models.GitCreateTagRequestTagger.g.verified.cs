//HintName: G.Models.GitCreateTagRequestTagger.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object with information about the individual creating the tag.
    /// </summary>
    public sealed partial class GitCreateTagRequestTagger
    {
        /// <summary>
        /// The name of the author of the tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The email of the author of the tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// When this object was tagged. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTagRequestTagger" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the author of the tag
        /// </param>
        /// <param name="email">
        /// The email of the author of the tag
        /// </param>
        /// <param name="date">
        /// When this object was tagged. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GitCreateTagRequestTagger(
            string name,
            string email,
            global::System.DateTime? date)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTagRequestTagger" /> class.
        /// </summary>
        public GitCreateTagRequestTagger()
        {
        }
    }
}