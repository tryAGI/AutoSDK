//HintName: G.Models.ReposSetStatusCheckContextsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposSetStatusCheckContextsRequest2
    {
        /// <summary>
        /// The name of the status checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Contexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetStatusCheckContextsRequest2" /> class.
        /// </summary>
        /// <param name="contexts">
        /// The name of the status checks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposSetStatusCheckContextsRequest2(
            global::System.Collections.Generic.IList<string> contexts)
        {
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetStatusCheckContextsRequest2" /> class.
        /// </summary>
        public ReposSetStatusCheckContextsRequest2()
        {
        }
    }
}