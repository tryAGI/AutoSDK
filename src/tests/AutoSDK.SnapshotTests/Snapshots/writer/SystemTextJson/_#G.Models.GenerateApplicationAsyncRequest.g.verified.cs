//HintName: G.Models.GenerateApplicationAsyncRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationAsyncRequest
    {
        /// <summary>
        /// A list of input objects to generate content for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// A list of input objects to generate content for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateApplicationAsyncRequest(
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncRequest" /> class.
        /// </summary>
        public GenerateApplicationAsyncRequest()
        {
        }
    }
}