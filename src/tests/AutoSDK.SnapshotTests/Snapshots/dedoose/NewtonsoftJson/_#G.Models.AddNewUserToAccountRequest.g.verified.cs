﻿//HintName: G.Models.AddNewUserToAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddNewUserToAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastName", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastName { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("encryptedPass", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedPass { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewUserToAccountRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="encryptedPass"></param>
        public AddNewUserToAccountRequest(
            global::System.Guid accountId,
            string username,
            string firstName,
            string lastName,
            string email,
            string phone,
            string encryptedPass)
        {
            this.AccountId = accountId;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.EncryptedPass = encryptedPass ?? throw new global::System.ArgumentNullException(nameof(encryptedPass));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewUserToAccountRequest" /> class.
        /// </summary>
        public AddNewUserToAccountRequest()
        {
        }
    }
}