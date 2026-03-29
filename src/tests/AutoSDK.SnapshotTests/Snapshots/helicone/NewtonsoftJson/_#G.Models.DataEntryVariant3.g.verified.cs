//HintName: G.Models.DataEntryVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataEntryVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DataEntryVariant3Content Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        public global::G.DataEntryVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntryVariant3" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        public DataEntryVariant3(
            global::G.DataEntryVariant3Content content,
            global::G.DataEntryVariant3Type type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntryVariant3" /> class.
        /// </summary>
        public DataEntryVariant3()
        {
        }
    }
}