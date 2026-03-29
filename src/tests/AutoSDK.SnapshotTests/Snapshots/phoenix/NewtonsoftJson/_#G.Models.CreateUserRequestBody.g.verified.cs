//HintName: G.Models.CreateUserRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUserRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.User User { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_welcome_email")]
        public bool? SendWelcomeEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBody" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sendWelcomeEmail">
        /// Default Value: true
        /// </param>
        public CreateUserRequestBody(
            global::G.User user,
            bool? sendWelcomeEmail)
        {
            this.User = user;
            this.SendWelcomeEmail = sendWelcomeEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBody" /> class.
        /// </summary>
        public CreateUserRequestBody()
        {
        }
    }
}