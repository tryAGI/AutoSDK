//HintName: G.Models.Sam3PromptEcho.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3PromptEcho
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_boxes")]
        public int? NumBoxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptEcho" /> class.
        /// </summary>
        /// <param name="promptIndex"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="numBoxes"></param>
        public Sam3PromptEcho(
            int promptIndex,
            string? type,
            string? text,
            int? numBoxes)
        {
            this.PromptIndex = promptIndex;
            this.Type = type;
            this.Text = text;
            this.NumBoxes = numBoxes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptEcho" /> class.
        /// </summary>
        public Sam3PromptEcho()
        {
        }
    }
}