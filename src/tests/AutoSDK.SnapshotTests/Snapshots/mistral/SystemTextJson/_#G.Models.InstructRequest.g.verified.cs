//HintName: G.Models.InstructRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InstructRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MessagesItem3> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstructRequest(
            global::System.Collections.Generic.IList<global::G.MessagesItem3> messages)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructRequest" /> class.
        /// </summary>
        public InstructRequest()
        {
        }
    }
}