//HintName: G.Models.ListSecretReferencesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSecretReferencesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ListSecretReferencesResponseObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.SecretReferenceListItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretReferencesResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="total"></param>
        /// <param name="data"></param>
        public ListSecretReferencesResponse(
            global::G.ListSecretReferencesResponseObject? @object,
            int? total,
            global::System.Collections.Generic.IList<global::G.SecretReferenceListItem>? data)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSecretReferencesResponse" /> class.
        /// </summary>
        public ListSecretReferencesResponse()
        {
        }
    }
}