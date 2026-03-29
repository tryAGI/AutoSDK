//HintName: G.Models.FunctionVersionsListInvocationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionVersionsListInvocationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Invocation> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersionsListInvocationsResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="total"></param>
        public FunctionVersionsListInvocationsResponse(
            global::System.Collections.Generic.IList<global::G.Invocation> results,
            int total)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersionsListInvocationsResponse" /> class.
        /// </summary>
        public FunctionVersionsListInvocationsResponse()
        {
        }
    }
}