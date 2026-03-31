//HintName: G.Models.EntityCompanyProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured properties for a company entity.
    /// </summary>
    public sealed partial class EntityCompanyProperties
    {
        /// <summary>
        /// Company name.<br/>
        /// Example: Exa
        /// </summary>
        /// <example>Exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Year the company was founded.<br/>
        /// Example: 2022
        /// </summary>
        /// <example>2022</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("foundedYear")]
        public int? FoundedYear { get; set; }

        /// <summary>
        /// Brief description of the company.<br/>
        /// Example: AI-powered search engine
        /// </summary>
        /// <example>AI-powered search engine</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workforce")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EntityCompanyPropertiesWorkforce, object>))]
        public global::G.OneOf<global::G.EntityCompanyPropertiesWorkforce, object>? Workforce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EntityCompanyPropertiesHeadquarters, object>))]
        public global::G.OneOf<global::G.EntityCompanyPropertiesHeadquarters, object>? Headquarters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financials")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EntityCompanyPropertiesFinancials, object>))]
        public global::G.OneOf<global::G.EntityCompanyPropertiesFinancials, object>? Financials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webTraffic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EntityCompanyPropertiesWebTraffic, object>))]
        public global::G.OneOf<global::G.EntityCompanyPropertiesWebTraffic, object>? WebTraffic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyProperties" /> class.
        /// </summary>
        /// <param name="name">
        /// Company name.<br/>
        /// Example: Exa
        /// </param>
        /// <param name="foundedYear">
        /// Year the company was founded.<br/>
        /// Example: 2022
        /// </param>
        /// <param name="description">
        /// Brief description of the company.<br/>
        /// Example: AI-powered search engine
        /// </param>
        /// <param name="workforce"></param>
        /// <param name="headquarters"></param>
        /// <param name="financials"></param>
        /// <param name="webTraffic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityCompanyProperties(
            string? name,
            int? foundedYear,
            string? description,
            global::G.OneOf<global::G.EntityCompanyPropertiesWorkforce, object>? workforce,
            global::G.OneOf<global::G.EntityCompanyPropertiesHeadquarters, object>? headquarters,
            global::G.OneOf<global::G.EntityCompanyPropertiesFinancials, object>? financials,
            global::G.OneOf<global::G.EntityCompanyPropertiesWebTraffic, object>? webTraffic)
        {
            this.Name = name;
            this.FoundedYear = foundedYear;
            this.Description = description;
            this.Workforce = workforce;
            this.Headquarters = headquarters;
            this.Financials = financials;
            this.WebTraffic = webTraffic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyProperties" /> class.
        /// </summary>
        public EntityCompanyProperties()
        {
        }
    }
}