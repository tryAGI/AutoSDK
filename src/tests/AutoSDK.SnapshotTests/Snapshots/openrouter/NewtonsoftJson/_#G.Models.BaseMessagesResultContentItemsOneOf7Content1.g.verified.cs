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
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItems> Content { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("stdout", Required = global::Newtonsoft.Json.Required.Always)]
        public string Stdout { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7Content1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type"></param>
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