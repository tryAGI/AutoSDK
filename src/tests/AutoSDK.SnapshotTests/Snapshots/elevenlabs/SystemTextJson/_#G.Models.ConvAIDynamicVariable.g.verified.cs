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
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIDynamicVariable" /> class.
        /// </summary>
        /// <param name="variableName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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