//HintName: G.Models.TemplatesForkTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesForkTemplateRequest
    {
        /// <summary>
        /// Optional custom name for the forked template. If not provided, a random name will be generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesForkTemplateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional custom name for the forked template. If not provided, a random name will be generated.
        /// </param>
        public TemplatesForkTemplateRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesForkTemplateRequest" /> class.
        /// </summary>
        public TemplatesForkTemplateRequest()
        {
        }
    }
}