//HintName: G.Models.UpdateCurrentUserPasswordRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCurrentUserPasswordRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="UpdateCurrentUserPasswordRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        public UpdateCurrentUserPasswordRequest(
            global::System.Guid userId,
            string encryptedPass)
        {
            this.UserId = userId;
            this.EncryptedPass = encryptedPass ?? throw new global::System.ArgumentNullException(nameof(encryptedPass));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrentUserPasswordRequest" /> class.
        /// </summary>
        public UpdateCurrentUserPasswordRequest()
        {
        }
    }
}