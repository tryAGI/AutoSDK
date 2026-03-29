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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Year the company was founded.<br/>
        /// Example: 2022
        /// </summary>
        /// <example>2022</example>
        [global::Newtonsoft.Json.JsonProperty("foundedYear")]
        public int? FoundedYear { get; set; }

        /// <summary>
        /// Brief description of the company.<br/>
        /// Example: AI-powered search engine
        /// </summary>
        /// <example>AI-powered search engine</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workforce")]
        public global::G.OneOf<global::G.EntityCompanyPropertiesWorkforce, object>? Workforce { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headquarters")]
        public global::G.OneOf<global::G.EntityCompanyPropertiesHeadquarters, object>? Headquarters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("financials")]
        public global::G.OneOf<global::G.EntityCompanyPropertiesFinancials, object>? Financials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webTraffic")]
        public global::G.OneOf<global::G.EntityCompanyPropertiesWebTraffic, object>? WebTraffic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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