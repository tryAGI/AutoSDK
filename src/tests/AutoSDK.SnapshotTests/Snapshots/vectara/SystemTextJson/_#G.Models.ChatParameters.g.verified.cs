//HintName: G.Models.ChatParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to control chat behavior.
    /// </summary>
    public sealed partial class ChatParameters
    {
        /// <summary>
        /// Indicates whether to store chat message and response message.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}