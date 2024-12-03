//HintName: G.Models.AutoModSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoModSettings
    {
        /// <summary>
        /// The broadcaster’s ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The moderator’s ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// The default AutoMod level for the broadcaster. This field is **null** if the broadcaster has set one or more of the individual settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_level", Required = global::Newtonsoft.Json.Required.Always)]
        public int? OverallLevel { get; set; } = default!;

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disability", Required = global::Newtonsoft.Json.Required.Always)]
        public int Disability { get; set; } = default!;

        /// <summary>
        /// The Automod level for hostility involving aggression.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aggression", Required = global::Newtonsoft.Json.Required.Always)]
        public int Aggression { get; set; } = default!;

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexuality_sex_or_gender", Required = global::Newtonsoft.Json.Required.Always)]
        public int SexualitySexOrGender { get; set; } = default!;

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("misogyny", Required = global::Newtonsoft.Json.Required.Always)]
        public int Misogyny { get; set; } = default!;

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bullying", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bullying { get; set; } = default!;

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("swearing", Required = global::Newtonsoft.Json.Required.Always)]
        public int Swearing { get; set; } = default!;

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("race_ethnicity_or_religion", Required = global::Newtonsoft.Json.Required.Always)]
        public int RaceEthnicityOrReligion { get; set; } = default!;

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sex_based_terms", Required = global::Newtonsoft.Json.Required.Always)]
        public int SexBasedTerms { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModSettings" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The broadcaster’s ID.
        /// </param>
        /// <param name="moderatorId">
        /// The moderator’s ID.
        /// </param>
        /// <param name="overallLevel">
        /// The default AutoMod level for the broadcaster. This field is **null** if the broadcaster has set one or more of the individual settings.
        /// </param>
        /// <param name="disability">
        /// The Automod level for discrimination against disability.
        /// </param>
        /// <param name="aggression">
        /// The Automod level for hostility involving aggression.
        /// </param>
        /// <param name="sexualitySexOrGender">
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </param>
        /// <param name="misogyny">
        /// The Automod level for discrimination against women.
        /// </param>
        /// <param name="bullying">
        /// The Automod level for hostility involving name calling or insults.
        /// </param>
        /// <param name="swearing">
        /// The Automod level for profanity.
        /// </param>
        /// <param name="raceEthnicityOrReligion">
        /// The Automod level for racial discrimination.
        /// </param>
        /// <param name="sexBasedTerms">
        /// The Automod level for sexual content.
        /// </param>
        public AutoModSettings(
            string broadcasterId,
            string moderatorId,
            int? overallLevel,
            int disability,
            int aggression,
            int sexualitySexOrGender,
            int misogyny,
            int bullying,
            int swearing,
            int raceEthnicityOrReligion,
            int sexBasedTerms)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.OverallLevel = overallLevel;
            this.Disability = disability;
            this.Aggression = aggression;
            this.SexualitySexOrGender = sexualitySexOrGender;
            this.Misogyny = misogyny;
            this.Bullying = bullying;
            this.Swearing = swearing;
            this.RaceEthnicityOrReligion = raceEthnicityOrReligion;
            this.SexBasedTerms = sexBasedTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModSettings" /> class.
        /// </summary>
        public AutoModSettings()
        {
        }
    }
}