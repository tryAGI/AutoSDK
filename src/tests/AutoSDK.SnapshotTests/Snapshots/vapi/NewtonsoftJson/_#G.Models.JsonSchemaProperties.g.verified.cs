//HintName: G.Models.JsonSchemaProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is required if the type is "object". This specifies the properties of the object. This is a map of property names to JsonSchema objects.
    /// </summary>
    public sealed partial class JsonSchemaProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}