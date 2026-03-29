//HintName: G.Models.ComputerUse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Computer Use tool type.
    /// </summary>
    public sealed partial class ComputerUse
    {
        /// <summary>
        /// Required. The environment being operated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public global::G.ComputerUseEnvironment? Environment { get; set; }

        /// <summary>
        /// Optional. By default, predefined functions are included in the final model call. Some of them can be explicitly excluded from being automatically included. This can serve two purposes: 1. Using a more restricted / different action space. 2. Improving the definitions / instructions of predefined functions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludedPredefinedFunctions")]
        public global::System.Collections.Generic.IList<string>? ExcludedPredefinedFunctions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        /// <param name="environment">
        /// Required. The environment being operated.
        /// </param>
        /// <param name="excludedPredefinedFunctions">
        /// Optional. By default, predefined functions are included in the final model call. Some of them can be explicitly excluded from being automatically included. This can serve two purposes: 1. Using a more restricted / different action space. 2. Improving the definitions / instructions of predefined functions.
        /// </param>
        public ComputerUse(
            global::G.ComputerUseEnvironment? environment,
            global::System.Collections.Generic.IList<string>? excludedPredefinedFunctions)
        {
            this.Environment = environment;
            this.ExcludedPredefinedFunctions = excludedPredefinedFunctions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUse" /> class.
        /// </summary>
        public ComputerUse()
        {
        }
    }
}