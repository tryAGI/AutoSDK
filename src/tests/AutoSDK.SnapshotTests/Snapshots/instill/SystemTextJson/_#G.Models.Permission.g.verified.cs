//HintName: G.Models.Permission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission defines how a resource can be used.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Defines whether the resource can be modified.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}