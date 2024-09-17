//HintName: G.Models.Permission2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a resource can be used.
    /// </summary>
    public sealed partial class Permission2
    {
        /// <summary>
        /// Defines whether the resource can be modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}