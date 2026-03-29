//HintName: G.Models.CreditsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsResponse
    {
        /// <summary>
        /// User's current credit balance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public double Credits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        /// <param name="credits">
        /// User's current credit balance
        /// </param>
        public CreditsResponse(
            double credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsResponse" /> class.
        /// </summary>
        public CreditsResponse()
        {
        }
    }
}