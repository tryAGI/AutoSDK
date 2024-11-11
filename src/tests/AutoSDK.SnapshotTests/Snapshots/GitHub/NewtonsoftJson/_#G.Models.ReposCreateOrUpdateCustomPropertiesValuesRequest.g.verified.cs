//HintName: G.Models.ReposCreateOrUpdateCustomPropertiesValuesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateCustomPropertiesValuesRequest
    {
        /// <summary>
        /// A list of custom property names and associated values to apply to the repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomPropertyValue> Properties { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateCustomPropertiesValuesRequest" /> class.
        /// </summary>
        /// <param name="properties">
        /// A list of custom property names and associated values to apply to the repositories.
        /// </param>
        public ReposCreateOrUpdateCustomPropertiesValuesRequest(
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrUpdateCustomPropertiesValuesRequest" /> class.
        /// </summary>
        public ReposCreateOrUpdateCustomPropertiesValuesRequest()
        {
        }
    }
}