//HintName: G.Models.Password.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Password
    {
        /// <summary>
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userName", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The corresponding password to the new user to create. <br/>
        /// The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password", Required = global::Newtonsoft.Json.Required.Always)]
        public string Password1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        /// <param name="userName">
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </param>
        /// <param name="password1">
        /// The corresponding password to the new user to create. <br/>
        /// The password must be a string of 8 to 64 characters and must include at least three of the following character types: uppercase letters, lowercase letters, numbers, and special characters.
        /// </param>
        public Password(
            string userName,
            string password1)
        {
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Password1 = password1 ?? throw new global::System.ArgumentNullException(nameof(password1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Password" /> class.
        /// </summary>
        public Password()
        {
        }
    }
}