//HintName: G.Models.UpdateAutoModSettingsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoModSettingsBody
    {
        /// <summary>
        /// The Automod level for hostility involving aggression.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aggression")]
        public int? Aggression { get; set; }

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bullying")]
        public int? Bullying { get; set; }

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disability")]
        public int? Disability { get; set; }

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("misogyny")]
        public int? Misogyny { get; set; }

        /// <summary>
        /// The default AutoMod level for the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_level")]
        public int? OverallLevel { get; set; }

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("race_ethnicity_or_religion")]
        public int? RaceEthnicityOrReligion { get; set; }

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sex_based_terms")]
        public int? SexBasedTerms { get; set; }

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexuality_sex_or_gender")]
        public int? SexualitySexOrGender { get; set; }

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("swearing")]
        public int? Swearing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UpdateAutoModSettingsBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateAutoModSettingsBody>(
                json,
                jsonSerializerOptions);
        }

    }
}