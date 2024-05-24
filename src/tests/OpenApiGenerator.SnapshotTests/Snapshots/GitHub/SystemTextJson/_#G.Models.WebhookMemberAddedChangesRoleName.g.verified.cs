//HintName: G.Models.WebhookMemberAddedChangesRoleName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role assigned to the collaborator.
    /// </summary>
    public sealed partial class WebhookMemberAddedChangesRoleName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}