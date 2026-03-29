//HintName: G.Models.FunctionBuildBuiltFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionBuildBuiltFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionVersion CreatedVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildBuiltFunction" /> class.
        /// </summary>
        /// <param name="createdVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionBuildBuiltFunction(
            global::G.FunctionVersion createdVersion)
        {
            this.CreatedVersion = createdVersion ?? throw new global::System.ArgumentNullException(nameof(createdVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildBuiltFunction" /> class.
        /// </summary>
        public FunctionBuildBuiltFunction()
        {
        }
    }
}