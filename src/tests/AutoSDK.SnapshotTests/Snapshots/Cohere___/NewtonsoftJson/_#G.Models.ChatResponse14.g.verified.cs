//HintName: G.Models.ChatResponse14.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponse14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse14" /> class.
        /// </summary>
        /// <param name="data"></param>
        public ChatResponse14(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResponse14" /> class.
        /// </summary>
        public ChatResponse14()
        {
        }
    }
}