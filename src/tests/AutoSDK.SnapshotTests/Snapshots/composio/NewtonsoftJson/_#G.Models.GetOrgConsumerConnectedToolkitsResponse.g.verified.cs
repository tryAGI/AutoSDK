//HintName: G.Models.GetOrgConsumerConnectedToolkitsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgConsumerConnectedToolkitsResponse
    {
        /// <summary>
        /// Distinct active toolkit slugs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Toolkits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgConsumerConnectedToolkitsResponse" /> class.
        /// </summary>
        /// <param name="toolkits">
        /// Distinct active toolkit slugs.
        /// </param>
        public GetOrgConsumerConnectedToolkitsResponse(
            global::System.Collections.Generic.IList<string> toolkits)
        {
            this.Toolkits = toolkits ?? throw new global::System.ArgumentNullException(nameof(toolkits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgConsumerConnectedToolkitsResponse" /> class.
        /// </summary>
        public GetOrgConsumerConnectedToolkitsResponse()
        {
        }
    }
}