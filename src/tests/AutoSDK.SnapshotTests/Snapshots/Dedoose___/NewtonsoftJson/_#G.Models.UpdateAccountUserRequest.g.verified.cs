//HintName: G.Models.UpdateAccountUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAccountUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("phone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountUserRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="active"></param>
        public UpdateAccountUserRequest(
            global::System.Guid userId,
            string firstName,
            string lastName,
            string phone,
            string email,
            bool active)
        {
            this.UserId = userId;
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.Phone = phone ?? throw new global::System.ArgumentNullException(nameof(phone));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountUserRequest" /> class.
        /// </summary>
        public UpdateAccountUserRequest()
        {
        }
    }
}