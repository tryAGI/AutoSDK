//HintName: G.Models.PromptEditSubversionTemplateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptEditSubversionTemplateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heliconeTemplate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object HeliconeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEditSubversionTemplateParams" /> class.
        /// </summary>
        /// <param name="heliconeTemplate"></param>
        /// <param name="experimentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptEditSubversionTemplateParams(
            object heliconeTemplate,
            string? experimentId)
        {
            this.HeliconeTemplate = heliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(heliconeTemplate));
            this.ExperimentId = experimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEditSubversionTemplateParams" /> class.
        /// </summary>
        public PromptEditSubversionTemplateParams()
        {
        }
    }
}