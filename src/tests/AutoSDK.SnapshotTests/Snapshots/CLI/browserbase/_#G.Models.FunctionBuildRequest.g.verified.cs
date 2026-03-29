//HintName: G.Models.FunctionBuildRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionBuildRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entrypoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionNames")]
        public global::System.Collections.Generic.IList<string>? FunctionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildRequest" /> class.
        /// </summary>
        /// <param name="entrypoint"></param>
        /// <param name="functionNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionBuildRequest(
            string entrypoint,
            global::System.Collections.Generic.IList<string>? functionNames)
        {
            this.Entrypoint = entrypoint ?? throw new global::System.ArgumentNullException(nameof(entrypoint));
            this.FunctionNames = functionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildRequest" /> class.
        /// </summary>
        public FunctionBuildRequest()
        {
        }
    }
}