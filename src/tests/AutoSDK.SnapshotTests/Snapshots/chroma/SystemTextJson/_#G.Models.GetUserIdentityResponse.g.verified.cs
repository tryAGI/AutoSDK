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
        [global::System.Text.Json.Serialization.JsonPropertyName("databases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Databases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserIdentityResponse" /> class.
        /// </summary>
        /// <param name="databases"></param>
        /// <param name="tenant"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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