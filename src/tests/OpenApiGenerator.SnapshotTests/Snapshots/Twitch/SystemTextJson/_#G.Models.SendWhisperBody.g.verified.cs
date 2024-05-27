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
        /// The whisper message to send. The message must not be empty.  
        ///   
        /// The maximum message lengths are:  
        ///   
        /// * 500 characters if the user you're sending the message to hasn't whispered you before.
        /// * 10,000 characters if the user you're sending the message to has whispered you before.
        ///   
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
    }
}