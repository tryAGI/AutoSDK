//HintName: G.Models.SchemaKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key-specific index overrides<br/>
    /// TODO(Sanket): Needed for backwards compatibility. Should remove after deploy.
    /// </summary>
    public sealed partial class SchemaKeys
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}