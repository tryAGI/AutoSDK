//HintName: G.Models.GetUserIdentityResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserIdentityResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("databases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Databases { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tenant { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserIdentityResponse" /> class.
        /// </summary>
        /// <param name="databases"></param>
        /// <param name="tenant"></param>
        /// <param name="userId"></param>
        public GetUserIdentityResponse(
            global::System.Collections.Generic.IList<string> databases,
            string tenant,
            string userId)
        {
            this.Databases = databases ?? throw new global::System.ArgumentNullException(nameof(databases));
            this.Tenant = tenant ?? throw new global::System.ArgumentNullException(nameof(tenant));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserIdentityResponse" /> class.
        /// </summary>
        public GetUserIdentityResponse()
        {
        }
    }
}