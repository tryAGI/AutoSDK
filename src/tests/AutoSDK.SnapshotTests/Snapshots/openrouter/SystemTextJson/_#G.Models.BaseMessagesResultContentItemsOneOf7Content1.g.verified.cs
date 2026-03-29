//HintName: G.Models.BaseMessagesResultContentItemsOneOf7Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf7Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReturnCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stderr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stdout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf7Content1(
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems> content,
            double returnCode,
            string stderr,
            string stdout,
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1Type type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ReturnCode = returnCode;
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Stdout = stdout ?? throw new global::System.ArgumentNullException(nameof(stdout));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content1" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content1()
        {
        }
    }
}