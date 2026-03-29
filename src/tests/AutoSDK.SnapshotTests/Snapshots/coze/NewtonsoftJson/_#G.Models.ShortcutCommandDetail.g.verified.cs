//HintName: G.Models.ShortcutCommandDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShortcutCommandDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("command_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommandId { get; set; } = default!;

        /// <summary>
        /// key=参数名 value=值  object_string object 数组序列化之后的 JSON String
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandDetail" /> class.
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="parameters">
        /// key=参数名 value=值  object_string object 数组序列化之后的 JSON String
        /// </param>
        public ShortcutCommandDetail(
            string commandId,
            global::System.Collections.Generic.Dictionary<string, string>? parameters)
        {
            this.CommandId = commandId ?? throw new global::System.ArgumentNullException(nameof(commandId));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandDetail" /> class.
        /// </summary>
        public ShortcutCommandDetail()
        {
        }
    }
}