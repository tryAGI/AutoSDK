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
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParamDetails" /> class.
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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