//HintName: G.Models.ModelCalculateConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost calculation formulas
    /// </summary>
    public sealed partial class ModelCalculateConfig
    {
        /// <summary>
        /// Mathematical operation for cost calculation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.ModelCalculateOperation? Request { get; set; }

        /// <summary>
        /// Mathematical operation for cost calculation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.ModelCalculateOperation? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCalculateConfig" /> class.
        /// </summary>
        /// <param name="request">
        /// Mathematical operation for cost calculation
        /// </param>
        /// <param name="response">
        /// Mathematical operation for cost calculation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCalculateConfig(
            global::G.ModelCalculateOperation? request,
            global::G.ModelCalculateOperation? response)
        {
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCalculateConfig" /> class.
        /// </summary>
        public ModelCalculateConfig()
        {
        }
    }
}