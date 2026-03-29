//HintName: G.Models.TransferOwnershipRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to transfer the ownership of the tuned model.
    /// </summary>
    public sealed partial class TransferOwnershipRequest
    {
        /// <summary>
        /// Required. The email address of the user to whom the tuned model is being transferred to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOwnershipRequest" /> class.
        /// </summary>
        /// <param name="emailAddress">
        /// Required. The email address of the user to whom the tuned model is being transferred to.
        /// </param>
        public TransferOwnershipRequest(
            string? emailAddress)
        {
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferOwnershipRequest" /> class.
        /// </summary>
        public TransferOwnershipRequest()
        {
        }
    }
}