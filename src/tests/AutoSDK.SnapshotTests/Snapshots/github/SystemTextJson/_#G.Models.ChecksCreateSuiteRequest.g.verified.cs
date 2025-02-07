//HintName: G.Models.ChecksCreateSuiteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateSuiteRequest
    {
        /// <summary>
        /// The sha of the head commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateSuiteRequest" /> class.
        /// </summary>
        /// <param name="headSha">
        /// The sha of the head commit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksCreateSuiteRequest(
            string headSha)
        {
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateSuiteRequest" /> class.
        /// </summary>
        public ChecksCreateSuiteRequest()
        {
        }
    }
}