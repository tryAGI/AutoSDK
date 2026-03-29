//HintName: G.Models.EntityCompanyPropertiesWorkforce.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Company workforce information.
    /// </summary>
    public sealed partial class EntityCompanyPropertiesWorkforce
    {
        /// <summary>
        /// Total number of employees.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesWorkforce" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of employees.<br/>
        /// Example: 500
        /// </param>
        public EntityCompanyPropertiesWorkforce(
            int? total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCompanyPropertiesWorkforce" /> class.
        /// </summary>
        public EntityCompanyPropertiesWorkforce()
        {
        }
    }
}