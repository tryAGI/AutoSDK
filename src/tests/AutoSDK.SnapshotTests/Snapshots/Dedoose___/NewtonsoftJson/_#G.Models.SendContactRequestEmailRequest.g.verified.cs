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
        [global::Newtonsoft.Json.JsonProperty("firstname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Firstname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Lastname { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("institution", Required = global::Newtonsoft.Json.Required.Always)]
        public string Institution { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Comments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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