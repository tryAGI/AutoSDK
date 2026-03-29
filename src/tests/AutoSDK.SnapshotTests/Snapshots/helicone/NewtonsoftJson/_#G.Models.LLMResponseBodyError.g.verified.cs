//HintName: G.Models.LLMResponseBodyError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("heliconeMessage", Required = global::Newtonsoft.Json.Required.Always)]
        public object HeliconeMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyError" /> class.
        /// </summary>
        /// <param name="heliconeMessage"></param>
        public LLMResponseBodyError(
            object heliconeMessage)
        {
            this.HeliconeMessage = heliconeMessage ?? throw new global::System.ArgumentNullException(nameof(heliconeMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyError" /> class.
        /// </summary>
        public LLMResponseBodyError()
        {
        }
    }
}