//HintName: G.Models.MigrationsMapCommitAuthorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsMapCommitAuthorRequest
    {
        /// <summary>
        /// The new Git author email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The new Git author name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsMapCommitAuthorRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// The new Git author email.
        /// </param>
        /// <param name="name">
        /// The new Git author name.
        /// </param>
        public MigrationsMapCommitAuthorRequest(
            string? email,
            string? name)
        {
            this.Email = email;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsMapCommitAuthorRequest" /> class.
        /// </summary>
        public MigrationsMapCommitAuthorRequest()
        {
        }
    }
}