//HintName: G.Models.UserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserResponse
    {
        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the user.
        /// </param>
        /// <param name="email">
        /// Email address of the user.
        /// </param>
        /// <param name="name">
        /// Name of the user.
        /// </param>
        public UserResponse(
            string id,
            string? email,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        public UserResponse()
        {
        }
    }
}