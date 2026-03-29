//HintName: G.Models.GetVirtualKeysResponseData2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVirtualKeysResponseData2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponseData2" /> class.
        /// </summary>
        /// <param name="message"></param>
        public GetVirtualKeysResponseData2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualKeysResponseData2" /> class.
        /// </summary>
        public GetVirtualKeysResponseData2()
        {
        }
    }
}