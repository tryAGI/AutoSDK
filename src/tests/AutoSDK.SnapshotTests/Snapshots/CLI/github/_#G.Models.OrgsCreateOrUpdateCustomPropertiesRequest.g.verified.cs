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
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CustomProperty> Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateOrUpdateCustomPropertiesRequest" /> class.
        /// </summary>
        /// <param name="properties">
        /// The array of custom properties to create or update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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