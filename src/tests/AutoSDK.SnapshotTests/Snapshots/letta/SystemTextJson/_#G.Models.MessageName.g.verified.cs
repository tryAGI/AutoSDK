//HintName: G.Models.MessageName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For role user/assistant: the (optional) name of the participant. For role tool/function: the name of the function called.
    /// </summary>
    public sealed partial class MessageName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}