//HintName: G.Models.ListFineTuningsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFineTuningsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.ListFineTuningsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        public ListFineTuningsResponse(
            global::System.Collections.Generic.IList<global::G.ListFineTuningsResponseDataItem>? data,
            string? @object)
        {
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningsResponse" /> class.
        /// </summary>
        public ListFineTuningsResponse()
        {
        }
    }
}