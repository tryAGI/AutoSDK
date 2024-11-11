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
        [global::Newtonsoft.Json.JsonProperty("genders", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Genders { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Accents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceGenerationParameterOptionResponseModel> Ages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_characters", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinimumCharacters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_characters", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaximumCharacters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minimum_accent_strength", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinimumAccentStrength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_accent_strength", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaximumAccentStrength { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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