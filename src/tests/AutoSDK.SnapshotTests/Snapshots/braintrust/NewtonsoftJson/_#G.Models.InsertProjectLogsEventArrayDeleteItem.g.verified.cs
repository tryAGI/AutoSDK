//HintName: G.Models.InsertProjectLogsEventArrayDeleteItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertProjectLogsEventArrayDeleteItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Delete { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventArrayDeleteItem" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="delete"></param>
        public InsertProjectLogsEventArrayDeleteItem(
            global::System.Collections.Generic.IList<string> path,
            global::System.Collections.Generic.IList<object> delete)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Delete = delete ?? throw new global::System.ArgumentNullException(nameof(delete));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertProjectLogsEventArrayDeleteItem" /> class.
        /// </summary>
        public InsertProjectLogsEventArrayDeleteItem()
        {
        }
    }
}