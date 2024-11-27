//HintName: G.Models.SetUserPasswordRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetUserPasswordRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rsaEncrptedPass", Required = global::Newtonsoft.Json.Required.Always)]
        public string RsaEncrptedPass { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rsaEncrptedPass"></param>
        public SetUserPasswordRequest(
            global::System.Guid userId,
            string rsaEncrptedPass)
        {
            this.UserId = userId;
            this.RsaEncrptedPass = rsaEncrptedPass ?? throw new global::System.ArgumentNullException(nameof(rsaEncrptedPass));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        public SetUserPasswordRequest()
        {
        }
    }
}