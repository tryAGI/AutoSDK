//HintName: G.Models.GetOrganizationResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationResponse2
    {
        /// <summary>
        /// Example: Organization not found
        /// </summary>
        /// <example>Organization not found</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Organization not found
        /// </param>
        public GetOrganizationResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse2" /> class.
        /// </summary>
        public GetOrganizationResponse2()
        {
        }
    }
}