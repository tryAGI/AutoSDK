//HintName: G.Models.CheckAPIKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAPIKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Valid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAPIKeyResponse" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="ownerId"></param>
        /// <param name="valid"></param>
        public CheckAPIKeyResponse(
            bool valid,
            string? organizationId,
            string? ownerId)
        {
            this.Valid = valid;
            this.OrganizationId = organizationId;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAPIKeyResponse" /> class.
        /// </summary>
        public CheckAPIKeyResponse()
        {
        }
    }
}