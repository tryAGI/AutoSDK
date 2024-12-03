//HintName: G.Models.CreateVariationNoBGRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationNoBGRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isVariation")]
        public bool? IsVariation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        public CreateVariationNoBGRequest(
            string id,
            bool? isVariation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsVariation = isVariation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGRequest" /> class.
        /// </summary>
        public CreateVariationNoBGRequest()
        {
        }
    }
}