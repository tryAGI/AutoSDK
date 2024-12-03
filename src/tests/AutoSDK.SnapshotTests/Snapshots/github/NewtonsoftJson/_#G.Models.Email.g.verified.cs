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
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email1 { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("primary", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Primary { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Verified { get; set; } = default!;

        /// <summary>
        /// Example: public
        /// </summary>
        /// <example>public</example>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Visibility { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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