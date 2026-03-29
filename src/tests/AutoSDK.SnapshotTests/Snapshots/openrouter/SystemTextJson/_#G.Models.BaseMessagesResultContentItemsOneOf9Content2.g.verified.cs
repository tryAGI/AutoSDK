//HintName: G.Models.BaseMessagesResultContentItemsOneOf9Content2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf9Content2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_file_update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFileUpdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content2" /> class.
        /// </summary>
        /// <param name="isFileUpdate"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf9Content2(
            bool isFileUpdate,
            global::G.BaseMessagesResultContentItemsOneOf9ContentOneOf2Type type)
        {
            this.IsFileUpdate = isFileUpdate;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf9Content2" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf9Content2()
        {
        }
    }
}