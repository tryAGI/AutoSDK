//HintName: G.Models.Lead.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lead
    {
        /// <summary>
        /// Unique identifier for the lead<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </summary>
        /// <example>cfd531e0-82fc-11e9-bc42-526af7764f64</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the lead<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Email address of the lead<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number of the lead<br/>
        /// Example: +1234567890
        /// </summary>
        /// <example>+1234567890</example>
        [global::Newtonsoft.Json.JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// ID of the chatflow the lead is associated with<br/>
        /// Example: 7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02
        /// </summary>
        /// <example>7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02</example>
        [global::Newtonsoft.Json.JsonProperty("chatflowid")]
        public string? Chatflowid { get; set; }

        /// <summary>
        /// ID of the chat session the lead is associated with<br/>
        /// Example: d7b0b5d8-85e6-4f2a-9c1f-9d9a0e2ebf6b
        /// </summary>
        /// <example>d7b0b5d8-85e6-4f2a-9c1f-9d9a0e2ebf6b</example>
        [global::Newtonsoft.Json.JsonProperty("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Date and time when the lead was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Lead" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the lead<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the lead<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="email">
        /// Email address of the lead<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="phone">
        /// Phone number of the lead<br/>
        /// Example: +1234567890
        /// </param>
        /// <param name="chatflowid">
        /// ID of the chatflow the lead is associated with<br/>
        /// Example: 7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02
        /// </param>
        /// <param name="chatId">
        /// ID of the chat session the lead is associated with<br/>
        /// Example: d7b0b5d8-85e6-4f2a-9c1f-9d9a0e2ebf6b
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the lead was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        public Lead(
            global::System.Guid? id,
            string? name,
            string? email,
            string? phone,
            string? chatflowid,
            string? chatId,
            global::System.DateTime? createdDate)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Chatflowid = chatflowid;
            this.ChatId = chatId;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lead" /> class.
        /// </summary>
        public Lead()
        {
        }
    }
}