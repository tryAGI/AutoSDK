//HintName: G.Models.ListInboundNumbersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListInboundNumbersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inbound_numbers")]
        public global::System.Collections.Generic.IList<global::G.InboundNumber>? InboundNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInboundNumbersResponse" /> class.
        /// </summary>
        /// <param name="inboundNumbers"></param>
        public ListInboundNumbersResponse(
            global::System.Collections.Generic.IList<global::G.InboundNumber>? inboundNumbers)
        {
            this.InboundNumbers = inboundNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInboundNumbersResponse" /> class.
        /// </summary>
        public ListInboundNumbersResponse()
        {
        }
    }
}