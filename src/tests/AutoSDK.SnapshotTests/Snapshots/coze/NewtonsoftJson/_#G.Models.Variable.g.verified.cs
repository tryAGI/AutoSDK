//HintName: G.Models.Variable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Variable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public global::G.VariableChannel? Channel { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 变量描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// 变量名
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 变量默认支持在Prompt中访问，取消勾选后将不支持在Prompt中访问（仅能在Workflow中访问
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_enable")]
        public bool? PromptEnable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="defaultValue">
        /// 默认值
        /// </param>
        /// <param name="description">
        /// 变量描述
        /// </param>
        /// <param name="enable">
        /// 是否启用
        /// </param>
        /// <param name="keyword">
        /// 变量名
        /// </param>
        /// <param name="promptEnable">
        /// 变量默认支持在Prompt中访问，取消勾选后将不支持在Prompt中访问（仅能在Workflow中访问
        /// </param>
        public Variable(
            global::G.VariableChannel? channel,
            string? defaultValue,
            string? description,
            bool? enable,
            string? keyword,
            bool? promptEnable)
        {
            this.Channel = channel;
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.Enable = enable;
            this.Keyword = keyword;
            this.PromptEnable = promptEnable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Variable" /> class.
        /// </summary>
        public Variable()
        {
        }
    }
}