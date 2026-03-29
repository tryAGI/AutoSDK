//HintName: G.Models.GetVirtualKeysResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVirtualKeysResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.GetVirtualKeysResponseData2? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponse3" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
        public GetVirtualKeysResponse3(
            bool? success,
            global::G.GetVirtualKeysResponseData2? data)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponse3" /> class.
        /// </summary>
        public GetVirtualKeysResponse3()
        {
        }
    }
}