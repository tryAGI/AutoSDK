//HintName: G.Models.GetInputsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInputsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("random")]
        public bool? Random { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInputsRequest" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="random"></param>
        public GetInputsRequest(
            double limit,
            bool? random)
        {
            this.Random = random;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInputsRequest" /> class.
        /// </summary>
        public GetInputsRequest()
        {
        }
    }
}