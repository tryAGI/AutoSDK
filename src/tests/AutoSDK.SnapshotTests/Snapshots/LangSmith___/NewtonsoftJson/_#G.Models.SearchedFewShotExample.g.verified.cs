//HintName: G.Models.SearchedFewShotExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchedFewShotExample
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Outputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug_info")]
        public object? DebugInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedFewShotExample" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="id"></param>
        /// <param name="debugInfo"></param>
        public SearchedFewShotExample(
            object inputs,
            object outputs,
            global::System.Guid id,
            object? debugInfo)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Id = id;
            this.DebugInfo = debugInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedFewShotExample" /> class.
        /// </summary>
        public SearchedFewShotExample()
        {
        }
    }
}