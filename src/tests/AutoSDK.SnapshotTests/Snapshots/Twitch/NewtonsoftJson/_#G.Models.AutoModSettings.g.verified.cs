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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
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
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.AutoModSettings>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.AutoModSettings?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.AutoModSettings?>(serializer.Deserialize<global::G.AutoModSettings>(jsonReader));
        }

    }
}