//HintName: G.Models.StatusCheckPolicyCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatusCheckPolicyCheck
    {
        /// <summary>
        /// Example: continuous-integration/travis-ci
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? AppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}