//HintName: G.Models.RangesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RangesResponse
    {
        /// <summary>
        /// Example: comcast.net
        /// </summary>
        /// <example>comcast.net</example>
        [global::Newtonsoft.Json.JsonProperty("domain", Required = global::Newtonsoft.Json.Required.Always)]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// Example: 37330
        /// </summary>
        /// <example>37330</example>
        [global::Newtonsoft.Json.JsonProperty("num_ranges", Required = global::Newtonsoft.Json.Required.Always)]
        public string NumRanges { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranges", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Ranges { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RangesResponse" /> class.
        /// </summary>
        /// <param name="domain">
        /// Example: comcast.net
        /// </param>
        /// <param name="numRanges">
        /// Example: 37330
        /// </param>
        /// <param name="ranges"></param>
        public RangesResponse(
            string domain,
            string numRanges,
            global::System.Collections.Generic.IList<string> ranges)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.NumRanges = numRanges ?? throw new global::System.ArgumentNullException(nameof(numRanges));
            this.Ranges = ranges ?? throw new global::System.ArgumentNullException(nameof(ranges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangesResponse" /> class.
        /// </summary>
        public RangesResponse()
        {
        }
    }
}