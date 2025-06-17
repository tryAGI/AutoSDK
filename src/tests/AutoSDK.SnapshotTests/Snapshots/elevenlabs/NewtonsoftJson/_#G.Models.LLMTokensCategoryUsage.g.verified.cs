﻿//HintName: G.Models.LLMTokensCategoryUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMTokensCategoryUsage
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public int? Tokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMTokensCategoryUsage" /> class.
        /// </summary>
        /// <param name="tokens">
        /// Default Value: 0
        /// </param>
        /// <param name="price">
        /// Default Value: 0
        /// </param>
        public LLMTokensCategoryUsage(
            int? tokens,
            double? price)
        {
            this.Tokens = tokens;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMTokensCategoryUsage" /> class.
        /// </summary>
        public LLMTokensCategoryUsage()
        {
        }
    }
}