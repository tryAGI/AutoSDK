//HintName: G.Models.SendContactRequestEmailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendContactRequestEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Institution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendContactRequestEmailRequest" /> class.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="institution"></param>
        /// <param name="comments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendContactRequestEmailRequest(
            string firstname,
            string lastname,
            string email,
            string phone,
            string institution,
            string comments)
        {
            this.Firstname = firstname ?? throw new global::System.ArgumentNullException(nameof(firstname));
            this.Lastname = lastname ?? throw new global::System.ArgumentNullException(nameof(lastname));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.Institution = institution ?? throw new global::System.ArgumentNullException(nameof(institution));
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendContactRequestEmailRequest" /> class.
        /// </summary>
        public SendContactRequestEmailRequest()
        {
        }
    }
}