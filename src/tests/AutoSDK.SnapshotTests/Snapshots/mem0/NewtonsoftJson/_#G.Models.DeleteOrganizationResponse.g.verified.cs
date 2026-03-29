//HintName: G.Models.DeleteOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOrganizationResponse
    {
        /// <summary>
        /// Example: Organization deleted successfully!
        /// </summary>
        /// <example>Organization deleted successfully!</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Organization deleted successfully!
        /// </param>
        public DeleteOrganizationResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationResponse" /> class.
        /// </summary>
        public DeleteOrganizationResponse()
        {
        }
    }
}