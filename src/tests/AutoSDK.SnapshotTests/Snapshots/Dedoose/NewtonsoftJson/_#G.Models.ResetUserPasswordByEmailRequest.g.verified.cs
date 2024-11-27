//HintName: G.Models.ResetUserPasswordByEmailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetUserPasswordByEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userEmail", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserEmail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByEmailRequest" /> class.
        /// </summary>
        /// <param name="userEmail"></param>
        public ResetUserPasswordByEmailRequest(
            string userEmail)
        {
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByEmailRequest" /> class.
        /// </summary>
        public ResetUserPasswordByEmailRequest()
        {
        }
    }
}