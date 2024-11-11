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
        [global::Newtonsoft.Json.JsonProperty("entities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EntitiesItem> Entities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareTokensResponse" /> class.
        /// </summary>
        /// <param name="entities"></param>
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