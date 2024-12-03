//HintName: G.Models.TopLogprobsData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopLogprobsData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopLogprobsData" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="logprob"></param>
        public TopLogprobsData(
            string token,
            double logprob)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopLogprobsData" /> class.
        /// </summary>
        public TopLogprobsData()
        {
        }
    }
}