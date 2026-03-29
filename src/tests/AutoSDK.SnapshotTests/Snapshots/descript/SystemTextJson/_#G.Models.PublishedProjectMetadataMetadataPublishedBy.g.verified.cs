//HintName: G.Models.PublishedProjectMetadataMetadataPublishedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the user who published the project
    /// </summary>
    public sealed partial class PublishedProjectMetadataMetadataPublishedBy
    {
        /// <summary>
        /// First name of the publisher<br/>
        /// Example: Jane
        /// </summary>
        /// <example>Jane</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name of the publisher<br/>
        /// Example: Doe
        /// </summary>
        /// <example>Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadataMetadataPublishedBy" /> class.
        /// </summary>
        /// <param name="firstName">
        /// First name of the publisher<br/>
        /// Example: Jane
        /// </param>
        /// <param name="lastName">
        /// Last name of the publisher<br/>
        /// Example: Doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishedProjectMetadataMetadataPublishedBy(
            string? firstName,
            string? lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectMetadataMetadataPublishedBy" /> class.
        /// </summary>
        public PublishedProjectMetadataMetadataPublishedBy()
        {
        }
    }
}