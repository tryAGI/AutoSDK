//HintName: G.Models.GetVirtualKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVirtualKeysResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.GetVirtualKeysResponseObject? Object { get; set; }

        /// <summary>
        /// Total number of virtual keys
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.VirtualKeys>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="total">
        /// Total number of virtual keys
        /// </param>
        /// <param name="data"></param>
        public GetVirtualKeysResponse(
            global::G.GetVirtualKeysResponseObject? @object,
            int? total,
            global::System.Collections.Generic.IList<global::G.VirtualKeys>? data)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponse" /> class.
        /// </summary>
        public GetVirtualKeysResponse()
        {
        }
    }
}