//HintName: G.Models.GetModelPricingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelPricingResponse
    {
        /// <summary>
        /// Example: Model not found
        /// </summary>
        /// <example>Model not found</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelPricingResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Model not found
        /// </param>
        public GetModelPricingResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelPricingResponse" /> class.
        /// </summary>
        public GetModelPricingResponse()
        {
        }
    }
}