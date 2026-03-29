//HintName: G.Models.CreateChatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatRequest
    {
        /// <summary>
        /// If true, the chat will be saved and won't be deleted automatically<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatRequest" /> class.
        /// </summary>
        /// <param name="persist">
        /// If true, the chat will be saved and won't be deleted automatically<br/>
        /// Default Value: false
        /// </param>
        public CreateChatRequest(
            bool? persist)
        {
            this.Persist = persist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatRequest" /> class.
        /// </summary>
        public CreateChatRequest()
        {
        }
    }
}