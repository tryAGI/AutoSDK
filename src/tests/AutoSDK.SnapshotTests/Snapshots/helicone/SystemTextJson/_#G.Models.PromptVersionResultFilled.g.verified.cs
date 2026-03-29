//HintName: G.Models.PromptVersionResultFilled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionResultFilled
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
        [global::System.Text.Json.Serialization.JsonPropertyName("minor_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("major_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MajorVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filled_helicone_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FilledHeliconeTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResultFilled" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="minorVersion"></param>
        /// <param name="majorVersion"></param>
        /// <param name="promptV2"></param>
        /// <param name="model"></param>
        /// <param name="filledHeliconeTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionResultFilled(
            string id,
            double minorVersion,
            double majorVersion,
            string promptV2,
            string model,
            object filledHeliconeTemplate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MinorVersion = minorVersion;
            this.MajorVersion = majorVersion;
            this.PromptV2 = promptV2 ?? throw new global::System.ArgumentNullException(nameof(promptV2));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FilledHeliconeTemplate = filledHeliconeTemplate ?? throw new global::System.ArgumentNullException(nameof(filledHeliconeTemplate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionResultFilled" /> class.
        /// </summary>
        public PromptVersionResultFilled()
        {
        }
    }
}