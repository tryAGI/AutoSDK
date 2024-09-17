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
        [global::Newtonsoft.Json.JsonProperty("canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}