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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: sprint.com
        /// </summary>
        /// <example>sprint.com</example>
        [global::Newtonsoft.Json.JsonProperty("domain", Required = global::Newtonsoft.Json.Required.Always)]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// Example: isp
        /// </summary>
        /// <example>isp</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompanyType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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