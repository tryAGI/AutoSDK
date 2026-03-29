//HintName: G.Models.FunctionIdInlineCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inline code function
    /// </summary>
    public sealed partial class FunctionIdInlineCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline_context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionIdInlineCodeInlineContext InlineContext { get; set; } = default!;

        /// <summary>
        /// The inline code to execute
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The name of the inline code function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlineCode" /> class.
        /// </summary>
        /// <param name="inlineContext"></param>
        /// <param name="code">
        /// The inline code to execute
        /// </param>
        /// <param name="name">
        /// The name of the inline code function
        /// </param>
        public FunctionIdInlineCode(
            global::G.FunctionIdInlineCodeInlineContext inlineContext,
            string code,
            string? name)
        {
            this.InlineContext = inlineContext ?? throw new global::System.ArgumentNullException(nameof(inlineContext));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdInlineCode" /> class.
        /// </summary>
        public FunctionIdInlineCode()
        {
        }
    }
}