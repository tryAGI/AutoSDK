//HintName: G.Models.ExportWithIdResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the export.
    /// </summary>
    public sealed partial class ExportWithIdResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWithIdResult" /> class.
        /// </summary>
        /// <param name="resultUrl"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportWithIdResult(
            string resultUrl,
            string? token)
        {
            this.Token = token;
            this.ResultUrl = resultUrl ?? throw new global::System.ArgumentNullException(nameof(resultUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWithIdResult" /> class.
        /// </summary>
        public ExportWithIdResult()
        {
        }
    }
}