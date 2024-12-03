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
        /// The new name of the user.<br/>
        /// Example: Omar Jahandar
        /// </summary>
        /// <example>Omar Jahandar</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The publicly visible email address of the user.<br/>
        /// Example: omar@example.com
        /// </summary>
        /// <example>omar@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The new blog URL of the user.<br/>
        /// Example: blog.example.com
        /// </summary>
        /// <example>blog.example.com</example>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// The new Twitter username of the user.<br/>
        /// Example: therealomarj
        /// </summary>
        /// <example>therealomarj</example>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// The new company of the user.<br/>
        /// Example: Acme corporation
        /// </summary>
        /// <example>Acme corporation</example>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// The new location of the user.<br/>
        /// Example: Berlin, Germany
        /// </summary>
        /// <example>Berlin, Germany</example>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The new hiring availability of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hireable")]
        public bool? Hireable { get; set; }

        /// <summary>
        /// The new short biography of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersUpdateAuthenticatedRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name of the user.<br/>
        /// Example: Omar Jahandar
        /// </param>
        /// <param name="email">
        /// The publicly visible email address of the user.<br/>
        /// Example: omar@example.com
        /// </param>
        /// <param name="blog">
        /// The new blog URL of the user.<br/>
        /// Example: blog.example.com
        /// </param>
        /// <param name="twitterUsername">
        /// The new Twitter username of the user.<br/>
        /// Example: therealomarj
        /// </param>
        /// <param name="company">
        /// The new company of the user.<br/>
        /// Example: Acme corporation
        /// </param>
        /// <param name="location">
        /// The new location of the user.<br/>
        /// Example: Berlin, Germany
        /// </param>
        /// <param name="hireable">
        /// The new hiring availability of the user.
        /// </param>
        /// <param name="bio">
        /// The new short biography of the user.
        /// </param>
        public UsersUpdateAuthenticatedRequest(
            string? name,
            string? email,
            string? blog,
            string? twitterUsername,
            string? company,
            string? location,
            bool? hireable,
            string? bio)
        {
            this.Name = name;
            this.Email = email;
            this.Blog = blog;
            this.TwitterUsername = twitterUsername;
            this.Company = company;
            this.Location = location;
            this.Hireable = hireable;
            this.Bio = bio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersUpdateAuthenticatedRequest" /> class.
        /// </summary>
        public UsersUpdateAuthenticatedRequest()
        {
        }
    }
}