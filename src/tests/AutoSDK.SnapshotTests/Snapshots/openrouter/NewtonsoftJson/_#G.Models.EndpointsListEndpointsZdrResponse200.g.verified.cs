//HintName: G.Models.EndpointsListEndpointsZdrResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointsListEndpointsZdrResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PublicEndpoint> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsListEndpointsZdrResponse200" /> class.
        /// </summary>
        /// <param name="data"></param>
        public EndpointsListEndpointsZdrResponse200(
            global::System.Collections.Generic.IList<global::G.PublicEndpoint> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsListEndpointsZdrResponse200" /> class.
        /// </summary>
        public EndpointsListEndpointsZdrResponse200()
        {
        }
    }
}