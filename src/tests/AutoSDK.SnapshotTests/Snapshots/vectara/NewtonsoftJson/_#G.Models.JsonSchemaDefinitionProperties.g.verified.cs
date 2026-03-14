//HintName: G.Models.JsonSchemaDefinitionProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Property definitions when type is 'object'. Each key maps to a nested JsonSchemaDefinition.
    /// </summary>
    public sealed partial class JsonSchemaDefinitionProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}