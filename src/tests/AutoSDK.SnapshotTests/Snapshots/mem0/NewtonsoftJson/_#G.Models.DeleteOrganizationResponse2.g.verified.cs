//HintName: G.Models.DeleteOrganizationResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOrganizationResponse2
    {
        /// <summary>
        /// Example: Unauthorized
        /// </summary>
        /// <example>Unauthorized</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Unauthorized
        /// </param>
        public DeleteOrganizationResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationResponse2" /> class.
        /// </summary>
        public DeleteOrganizationResponse2()
        {
        }
    }
}