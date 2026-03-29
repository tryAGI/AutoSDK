//HintName: G.Models.BaseMessagesResultContentItemsOneOf7Content2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf7Content2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedStdout { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encryptedStdout"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf7Content2(
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems> content,
            string encryptedStdout,
            double returnCode,
            string stderr,
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2Type type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.EncryptedStdout = encryptedStdout ?? throw new global::System.ArgumentNullException(nameof(encryptedStdout));
            this.ReturnCode = returnCode;
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content2" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7Content2()
        {
        }
    }
}