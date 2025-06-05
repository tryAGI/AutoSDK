//HintName: G.Models.MeIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeIn
    {
        /// <summary>
        /// Personal name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_business_account")]
        public bool? IsBusinessAccount { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Company website address
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeIn" /> class.
        /// </summary>
        /// <param name="name">
        /// Personal name
        /// </param>
        /// <param name="email"></param>
        /// <param name="isBusinessAccount"></param>
        /// <param name="company">
        /// Company name
        /// </param>
        /// <param name="website">
        /// Company website address
        /// </param>
        /// <param name="displayName">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        public MeIn(
            string? name,
            string? email,
            bool? isBusinessAccount,
            string? company,
            string? website,
            string? displayName)
        {
            this.Name = name;
            this.Email = email;
            this.IsBusinessAccount = isBusinessAccount;
            this.Company = company;
            this.Website = website;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeIn" /> class.
        /// </summary>
        public MeIn()
        {
        }
    }
}