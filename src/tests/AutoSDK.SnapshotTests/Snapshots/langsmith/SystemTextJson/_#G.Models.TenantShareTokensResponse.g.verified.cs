//HintName: G.Models.TenantShareTokensResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantShareTokensResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EntitiesItem> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareTokensResponse" /> class.
        /// </summary>
        /// <param name="entities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantShareTokensResponse(
            global::System.Collections.Generic.IList<global::G.EntitiesItem> entities)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareTokensResponse" /> class.
        /// </summary>
        public TenantShareTokensResponse()
        {
        }
    }
}