//HintName: G.Models.BodyExecuteApiV1AceExecutePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExecuteApiV1AceExecutePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Args { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExecuteApiV1AceExecutePost" /> class.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="code"></param>
        public BodyExecuteApiV1AceExecutePost(
            global::System.Collections.Generic.IList<object> args,
            string code)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExecuteApiV1AceExecutePost" /> class.
        /// </summary>
        public BodyExecuteApiV1AceExecutePost()
        {
        }
    }
}