﻿//HintName: G.Models.SingleGenerationTokenLikelihood.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleGenerationTokenLikelihood
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("likelihood", Required = global::Newtonsoft.Json.Required.Always)]
        public double Likelihood { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationTokenLikelihood" /> class.
        /// </summary>
        /// <param name="likelihood"></param>
        /// <param name="token"></param>
        public SingleGenerationTokenLikelihood(
            double likelihood,
            string token)
        {
            this.Likelihood = likelihood;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleGenerationTokenLikelihood" /> class.
        /// </summary>
        public SingleGenerationTokenLikelihood()
        {
        }
    }
}