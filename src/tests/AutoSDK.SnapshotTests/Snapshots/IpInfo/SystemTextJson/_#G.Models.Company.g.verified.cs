//HintName: G.Models.Company.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Company
    {
        /// <summary>
        /// Example: Sprint Springfield POP
        /// </summary>
        /// <example>Sprint Springfield POP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: sprint.com
        /// </summary>
        /// <example>sprint.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Example: isp
        /// </summary>
        /// <example>isp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompanyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompanyType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Sprint Springfield POP
        /// </param>
        /// <param name="domain">
        /// Example: sprint.com
        /// </param>
        /// <param name="type">
        /// Example: isp
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Company(
            string name,
            string domain,
            global::G.CompanyType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        public Company()
        {
        }
    }
}