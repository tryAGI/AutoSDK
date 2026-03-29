//HintName: G.Models.CodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeInput
    {
        /// <summary>
        /// Source code to parse for JSON schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The source type of the code (python or typescript)<br/>
        /// Default Value: python
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInput" /> class.
        /// </summary>
        /// <param name="code">
        /// Source code to parse for JSON schema
        /// </param>
        /// <param name="sourceType">
        /// The source type of the code (python or typescript)<br/>
        /// Default Value: python
        /// </param>
        public CodeInput(
            string code,
            string? sourceType)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInput" /> class.
        /// </summary>
        public CodeInput()
        {
        }
    }
}