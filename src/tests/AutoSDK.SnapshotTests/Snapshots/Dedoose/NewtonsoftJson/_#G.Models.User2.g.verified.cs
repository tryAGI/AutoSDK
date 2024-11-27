//HintName: G.Models.User2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passSalt")]
        public string? PassSalt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eulaStamp")]
        public global::System.DateTime? EulaStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adminDisable")]
        public bool? AdminDisable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastLogin")]
        public global::System.DateTime? LastLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changePass")]
        public bool? ChangePass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chagePassDate")]
        public global::System.DateTime? ChagePassDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="passSalt"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="createStamp"></param>
        /// <param name="phone"></param>
        /// <param name="eulaStamp"></param>
        /// <param name="isActive"></param>
        /// <param name="adminDisable"></param>
        /// <param name="accountId"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="lastLogin"></param>
        /// <param name="changePass"></param>
        /// <param name="chagePassDate"></param>
        /// <param name="isVerified"></param>
        public User2(
            global::System.Guid? id,
            string? username,
            string? passSalt,
            string? firstName,
            string? lastName,
            string? email,
            global::System.DateTime? createStamp,
            string? phone,
            global::System.DateTime? eulaStamp,
            bool? isActive,
            bool? adminDisable,
            global::System.Guid? accountId,
            string? address,
            string? city,
            string? state,
            string? country,
            string? zip,
            global::System.DateTime? lastLogin,
            bool? changePass,
            global::System.DateTime? chagePassDate,
            bool? isVerified)
        {
            this.Id = id;
            this.Username = username;
            this.PassSalt = passSalt;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CreateStamp = createStamp;
            this.Phone = phone;
            this.EulaStamp = eulaStamp;
            this.IsActive = isActive;
            this.AdminDisable = adminDisable;
            this.AccountId = accountId;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Zip = zip;
            this.LastLogin = lastLogin;
            this.ChangePass = changePass;
            this.ChagePassDate = chagePassDate;
            this.IsVerified = isVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User2" /> class.
        /// </summary>
        public User2()
        {
        }
    }
}