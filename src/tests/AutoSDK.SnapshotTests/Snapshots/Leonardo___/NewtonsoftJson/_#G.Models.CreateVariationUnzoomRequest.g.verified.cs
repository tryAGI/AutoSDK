//HintName: G.Models.CreateVariationUnzoomRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUnzoomRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        public CreateVariationUnzoomRequest(
            string? id,
            bool? isVariation)
        {
            this.Id = id;
            this.IsVariation = isVariation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomRequest" /> class.
        /// </summary>
        public CreateVariationUnzoomRequest()
        {
        }
    }
}