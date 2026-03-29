//HintName: G.Models.ListConfigsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConfigsResponse
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
        public global::System.Collections.Generic.IList<global::G.ListConfigsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
        public ListConfigsResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::G.ListConfigsResponseDataItem>? data)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigsResponse" /> class.
        /// </summary>
        public ListConfigsResponse()
        {
        }
    }
}