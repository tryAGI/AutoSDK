//HintName: G.Models.OrgsCreateOrUpdateCustomPropertiesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateOrUpdateCustomPropertiesRequest
    {
        /// <summary>
        /// The array of custom properties to create or update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomProperty> Properties { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertiesRequest" /> class.
        /// </summary>
        /// <param name="properties">
        /// The array of custom properties to create or update.
        /// </param>
        public OrgsCreateOrUpdateCustomPropertiesRequest(
            global::System.Collections.Generic.IList<global::G.CustomProperty> properties)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertiesRequest" /> class.
        /// </summary>
        public OrgsCreateOrUpdateCustomPropertiesRequest()
        {
        }
    }
}