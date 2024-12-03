//HintName: G.Models.CodeScanningAlertInstanceMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAlertInstanceMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstanceMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningAlertInstanceMessage(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstanceMessage" /> class.
        /// </summary>
        public CodeScanningAlertInstanceMessage()
        {
        }
    }
}