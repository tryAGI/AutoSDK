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
        [global::Newtonsoft.Json.JsonProperty("createdVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionVersion CreatedVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuildBuiltFunction" /> class.
        /// </summary>
        /// <param name="createdVersion"></param>
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