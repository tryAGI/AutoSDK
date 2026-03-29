//HintName: G.Models.SavedFunctionIdGlobal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SavedFunctionIdGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SavedFunctionIdGlobalType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedFunctionIdGlobal" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        public SavedFunctionIdGlobal(
            string name,
            global::G.SavedFunctionIdGlobalType type,
            global::G.FunctionTypeEnum? functionType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionType = functionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SavedFunctionIdGlobal" /> class.
        /// </summary>
        public SavedFunctionIdGlobal()
        {
        }
    }
}