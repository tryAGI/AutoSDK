//HintName: G.Models.DeleteVirtualKeysResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVirtualKeysResponse2
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
        public global::G.DeleteVirtualKeysResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVirtualKeysResponse2" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
        public DeleteVirtualKeysResponse2(
            bool? success,
            global::G.DeleteVirtualKeysResponseData? data)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVirtualKeysResponse2" /> class.
        /// </summary>
        public DeleteVirtualKeysResponse2()
        {
        }
    }
}