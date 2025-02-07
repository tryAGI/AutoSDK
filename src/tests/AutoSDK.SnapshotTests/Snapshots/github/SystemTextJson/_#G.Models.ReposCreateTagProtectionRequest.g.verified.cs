//HintName: G.Models.ReposCreateTagProtectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateTagProtectionRequest
    {
        /// <summary>
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateTagProtectionRequest" /> class.
        /// </summary>
        /// <param name="pattern">
        /// An optional glob pattern to match against when enforcing tag protection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateTagProtectionRequest(
            string pattern)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateTagProtectionRequest" /> class.
        /// </summary>
        public ReposCreateTagProtectionRequest()
        {
        }
    }
}