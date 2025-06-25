//HintName: G.Models.VoiceGenerationParameterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceGenerationParameterResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genders")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Genders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Accents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Ages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinimumCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaximumCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_accent_strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinimumAccentStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_accent_strength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaximumAccentStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceGenerationParameterResponseModel" /> class.
        /// </summary>
        /// <param name="genders"></param>
        /// <param name="accents"></param>
        /// <param name="ages"></param>
        /// <param name="minimumCharacters"></param>
        /// <param name="maximumCharacters"></param>
        /// <param name="minimumAccentStrength"></param>
        /// <param name="maximumAccentStrength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceGenerationParameterResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> genders,
            global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> accents,
            global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> ages,
            int minimumCharacters,
            int maximumCharacters,
            double minimumAccentStrength,
            double maximumAccentStrength)
        {
            this.Genders = genders ?? throw new global::System.ArgumentNullException(nameof(genders));
            this.Accents = accents ?? throw new global::System.ArgumentNullException(nameof(accents));
            this.Ages = ages ?? throw new global::System.ArgumentNullException(nameof(ages));
            this.MinimumCharacters = minimumCharacters;
            this.MaximumCharacters = maximumCharacters;
            this.MinimumAccentStrength = minimumAccentStrength;
            this.MaximumAccentStrength = maximumAccentStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceGenerationParameterResponseModel" /> class.
        /// </summary>
        public VoiceGenerationParameterResponseModel()
        {
        }
    }
}