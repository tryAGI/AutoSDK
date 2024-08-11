//HintName: G.Models.CustomPropertyValue.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Custom property name and associated value
    /// </summary>
    public sealed partial class CustomPropertyValue
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyName { get; set; } = default!;

        /// <summary>
        /// The value assigned to the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.OneOf<string?, global::System.Collections.Generic.IList<string>?>? Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}