//HintName: G.Models.UsersUpdateAuthenticatedRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersUpdateAuthenticatedRequest
    {
        /// <summary>
        /// The new name of the user.
        /// <br/>Example: Omar Jahandar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The publicly visible email address of the user.
        /// <br/>Example: omar@example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The new blog URL of the user.
        /// <br/>Example: blog.example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// The new Twitter username of the user.
        /// <br/>Example: therealomarj
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The new company of the user.
        /// <br/>Example: Acme corporation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// The new location of the user.
        /// <br/>Example: Berlin, Germany
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The new hiring availability of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hireable")]
        public bool Hireable { get; set; }

        /// <summary>
        /// The new short biography of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}