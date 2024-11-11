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
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The moderator’s ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModeratorId { get; set; }

        /// <summary>
        /// The default AutoMod level for the broadcaster. This field is **null** if the broadcaster has set one or more of the individual settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OverallLevel { get; set; }

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Disability { get; set; }

        /// <summary>
        /// The Automod level for hostility involving aggression.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Aggression { get; set; }

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexuality_sex_or_gender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SexualitySexOrGender { get; set; }

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misogyny")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Misogyny { get; set; }

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullying")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bullying { get; set; }

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swearing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Swearing { get; set; }

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("race_ethnicity_or_religion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RaceEthnicityOrReligion { get; set; }

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex_based_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SexBasedTerms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.AutoModSettings? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.AutoModSettings),
                jsonSerializerContext) as global::G.AutoModSettings;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.AutoModSettings? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.AutoModSettings>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.AutoModSettings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.AutoModSettings),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.AutoModSettings;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.AutoModSettings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.AutoModSettings?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}