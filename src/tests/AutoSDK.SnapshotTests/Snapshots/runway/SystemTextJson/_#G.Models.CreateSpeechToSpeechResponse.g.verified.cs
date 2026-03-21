//HintName: G.Models.CreateSpeechToSpeechResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpeechToSpeechResponse
    {
        /// <summary>
        /// The ID of the task that was created. Use this to retrieve the task later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task that was created. Use this to retrieve the task later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechToSpeechResponse(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechResponse" /> class.
        /// </summary>
        public CreateSpeechToSpeechResponse()
        {
        }
    }
}