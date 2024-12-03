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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVariation")]
        public bool? IsVariation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isVariation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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