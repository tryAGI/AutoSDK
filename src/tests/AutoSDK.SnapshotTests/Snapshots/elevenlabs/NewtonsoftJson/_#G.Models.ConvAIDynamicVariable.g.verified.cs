//HintName: G.Models.ConvAIDynamicVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used to reference a dynamic variable.
    /// </summary>
    public sealed partial class ConvAIDynamicVariable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variable_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VariableName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIDynamicVariable" /> class.
        /// </summary>
        /// <param name="variableName"></param>
        public ConvAIDynamicVariable(
            string variableName)
        {
            this.VariableName = variableName ?? throw new global::System.ArgumentNullException(nameof(variableName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIDynamicVariable" /> class.
        /// </summary>
        public ConvAIDynamicVariable()
        {
        }
    }
}