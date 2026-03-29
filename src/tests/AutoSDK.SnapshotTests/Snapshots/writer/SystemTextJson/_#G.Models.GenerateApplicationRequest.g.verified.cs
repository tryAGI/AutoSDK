//HintName: G.Models.GenerateApplicationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> Inputs { get; set; }

        /// <summary>
        /// Indicates whether the response should be streamed. Currently only supported for research assistant applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="stream">
        /// Indicates whether the response should be streamed. Currently only supported for research assistant applications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateApplicationRequest(
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs,
            bool? stream)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationRequest" /> class.
        /// </summary>
        public GenerateApplicationRequest()
        {
        }
    }
}