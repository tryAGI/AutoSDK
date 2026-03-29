//HintName: G.Models.UpdateResourceClientKeyDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResourceClientKeyDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceClientKeyDto" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        public UpdateResourceClientKeyDto(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            string? name)
        {
            this.AllowedDomains = allowedDomains;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceClientKeyDto" /> class.
        /// </summary>
        public UpdateResourceClientKeyDto()
        {
        }
    }
}