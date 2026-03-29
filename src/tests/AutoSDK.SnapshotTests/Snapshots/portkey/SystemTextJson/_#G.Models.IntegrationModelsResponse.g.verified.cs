//HintName: G.Models.IntegrationModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationModelsResponse
    {
        /// <summary>
        /// Total number of models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::G.IntegrationModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationModelsResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of models
        /// </param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationModelsResponse(
            int? total,
            global::System.Collections.Generic.IList<global::G.IntegrationModel>? models)
        {
            this.Total = total;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationModelsResponse" /> class.
        /// </summary>
        public IntegrationModelsResponse()
        {
        }
    }
}