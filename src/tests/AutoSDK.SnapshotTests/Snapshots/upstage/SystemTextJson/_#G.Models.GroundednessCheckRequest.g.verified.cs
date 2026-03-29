//HintName: G.Models.GroundednessCheckRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroundednessCheckRequest
    {
        /// <summary>
        /// The context/source text against which the answer will be verified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// The answer/response to check for groundedness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// The model to use for groundedness check.<br/>
        /// Default: groundedness-check<br/>
        /// Default Value: groundedness-check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckRequest" /> class.
        /// </summary>
        /// <param name="context">
        /// The context/source text against which the answer will be verified.
        /// </param>
        /// <param name="answer">
        /// The answer/response to check for groundedness.
        /// </param>
        /// <param name="model">
        /// The model to use for groundedness check.<br/>
        /// Default: groundedness-check<br/>
        /// Default Value: groundedness-check
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroundednessCheckRequest(
            string context,
            string answer,
            string? model)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckRequest" /> class.
        /// </summary>
        public GroundednessCheckRequest()
        {
        }
    }
}