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
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommandId { get; set; }

        /// <summary>
        /// key=参数名 value=值  object_string object 数组序列化之后的 JSON String
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCommandDetail" /> class.
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="parameters">
        /// key=参数名 value=值  object_string object 数组序列化之后的 JSON String
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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