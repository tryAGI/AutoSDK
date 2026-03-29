//HintName: G.Models.AIModelInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of input modes the model supports. Each mode groups mutually exclusive input slots. The frontend picks one mode. text_to_video (no inputs) is always implicitly available for VIDEO type models. Null means the model has no declarative input specifications (use requires_* booleans).
    /// </summary>
    public sealed partial class AIModelInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}