//HintName: G.Models.SendWhisperBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendWhisperBody
    {
        /// <summary>
        /// The whisper message to send. The message must not be empty.  <br/>
        ///   <br/>
        /// The maximum message lengths are:  <br/>
        ///   <br/>
        /// * 500 characters if the user you're sending the message to hasn't whispered you before.<br/>
        /// * 10,000 characters if the user you're sending the message to has whispered you before.<br/>
        ///   <br/>
        /// Messages that exceed the maximum length are truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendWhisperBody" /> class.
        /// </summary>
        /// <param name="message">
        /// The whisper message to send. The message must not be empty.  <br/>
        ///   <br/>
        /// The maximum message lengths are:  <br/>
        ///   <br/>
        /// * 500 characters if the user you're sending the message to hasn't whispered you before.<br/>
        /// * 10,000 characters if the user you're sending the message to has whispered you before.<br/>
        ///   <br/>
        /// Messages that exceed the maximum length are truncated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendWhisperBody(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendWhisperBody" /> class.
        /// </summary>
        public SendWhisperBody()
        {
        }
    }
}