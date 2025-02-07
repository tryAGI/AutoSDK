//HintName: G.Models.Email.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Email
    /// </summary>
    public sealed partial class Email
    {
        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email1 { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Primary { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// Example: public
        /// </summary>
        /// <example>public</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="email1">
        /// Example: octocat@github.com
        /// </param>
        /// <param name="primary">
        /// Example: true
        /// </param>
        /// <param name="verified">
        /// Example: true
        /// </param>
        /// <param name="visibility">
        /// Example: public
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Email(
            string email1,
            bool primary,
            bool verified,
            string? visibility)
        {
            this.Email1 = email1 ?? throw new global::System.ArgumentNullException(nameof(email1));
            this.Primary = primary;
            this.Verified = verified;
            this.Visibility = visibility ?? throw new global::System.ArgumentNullException(nameof(visibility));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        public Email()
        {
        }
    }
}