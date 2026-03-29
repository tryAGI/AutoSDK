//HintName: G.Models.BalanceResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"credits":0.07903292496944721}
    /// </summary>
    public sealed partial class BalanceResponseBody
    {
        /// <summary>
        /// The balance of the account/organization associated with the API key<br/>
        /// Example: 0.41122252F
        /// </summary>
        /// <example>0.41122252F</example>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public double Credits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseBody" /> class.
        /// </summary>
        /// <param name="credits">
        /// The balance of the account/organization associated with the API key<br/>
        /// Example: 0.41122252F
        /// </param>
        public BalanceResponseBody(
            double credits)
        {
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponseBody" /> class.
        /// </summary>
        public BalanceResponseBody()
        {
        }
    }
}