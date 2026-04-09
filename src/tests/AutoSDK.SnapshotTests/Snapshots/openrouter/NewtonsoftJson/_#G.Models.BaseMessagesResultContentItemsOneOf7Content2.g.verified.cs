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
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_stdout", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedStdout { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_code", Required = global::Newtonsoft.Json.Required.Always)]
        public double ReturnCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stderr", Required = global::Newtonsoft.Json.Required.Always)]
        public string Stderr { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encryptedStdout"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="type"></param>
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