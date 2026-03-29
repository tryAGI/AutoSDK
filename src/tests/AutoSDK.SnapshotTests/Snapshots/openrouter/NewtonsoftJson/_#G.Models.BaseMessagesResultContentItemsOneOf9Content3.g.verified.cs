//HintName: G.Models.BaseMessagesResultContentItemsOneOf9Content3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf9Content3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lines")]
        public global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_lines")]
        public double? NewLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_start")]
        public double? NewStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_lines")]
        public double? OldLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_start")]
        public double? OldStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content3" /> class.
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="newLines"></param>
        /// <param name="newStart"></param>
        /// <param name="oldLines"></param>
        /// <param name="oldStart"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf9Content3(
            global::System.Collections.Generic.IList<string>? lines,
            double? newLines,
            double? newStart,
            double? oldLines,
            double? oldStart,
            global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf3Type type)
        {
            this.Lines = lines;
            this.NewLines = newLines;
            this.NewStart = newStart;
            this.OldLines = oldLines;
            this.OldStart = oldStart;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content3" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf9Content3()
        {
        }
    }
}