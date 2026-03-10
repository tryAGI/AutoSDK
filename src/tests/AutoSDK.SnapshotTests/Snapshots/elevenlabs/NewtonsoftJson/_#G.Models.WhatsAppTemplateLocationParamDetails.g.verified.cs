//HintName: G.Models.WhatsAppTemplateLocationParamDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateLocationParamDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latitude", Required = global::Newtonsoft.Json.Required.Always)]
        public string Latitude { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("longitude", Required = global::Newtonsoft.Json.Required.Always)]
        public string Longitude { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address", Required = global::Newtonsoft.Json.Required.Always)]
        public string Address { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParamDetails" /> class.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public WhatsAppTemplateLocationParamDetails(
            string latitude,
            string longitude,
            string name,
            string address)
        {
            this.Latitude = latitude ?? throw new global::System.ArgumentNullException(nameof(latitude));
            this.Longitude = longitude ?? throw new global::System.ArgumentNullException(nameof(longitude));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParamDetails" /> class.
        /// </summary>
        public WhatsAppTemplateLocationParamDetails()
        {
        }
    }
}