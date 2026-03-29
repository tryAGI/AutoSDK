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
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.User User { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_welcome_email")]
        public bool? SendWelcomeEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBody" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sendWelcomeEmail">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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