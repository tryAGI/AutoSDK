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
        [global::System.Text.Json.Serialization.JsonPropertyName("heliconeMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object HeliconeMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyError" /> class.
        /// </summary>
        /// <param name="heliconeMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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