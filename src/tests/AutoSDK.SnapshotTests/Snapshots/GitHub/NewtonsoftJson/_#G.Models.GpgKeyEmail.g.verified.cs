//HintName: G.Models.GpgKeyEmail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GpgKeyEmail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeyEmail" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="verified"></param>
        public GpgKeyEmail(
            string? email,
            bool? verified)
        {
            this.Email = email;
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GpgKeyEmail" /> class.
        /// </summary>
        public GpgKeyEmail()
        {
        }
    }
}