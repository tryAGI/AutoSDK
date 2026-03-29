//HintName: G.Models.CreateChatRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatRequest2
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
        /// Initializes a new instance of the <see cref="CreateChatRequest2" /> class.
        /// </summary>
        /// <param name="persist">
        /// If true, the chat will be saved and won't be deleted automatically<br/>
        /// Default Value: false
        /// </param>
        public CreateChatRequest2(
            bool? persist)
        {
            this.Persist = persist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatRequest2" /> class.
        /// </summary>
        public CreateChatRequest2()
        {
        }
    }
}