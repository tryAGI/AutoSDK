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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task that was created. Use this to retrieve the task later.
        /// </param>
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