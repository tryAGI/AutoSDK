//HintName: G.Models.BuiltInTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuiltInTools
    {
        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call")]
        public global::G.SystemToolConfigInput? EndCall { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::G.SystemToolConfigInput? LanguageDetection { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::G.SystemToolConfigInput? TransferToAgent { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::G.SystemToolConfigInput? TransferToNumber { get; set; }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_turn")]
        public global::G.SystemToolConfigInput? SkipTurn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInTools" /> class.
        /// </summary>
        /// <param name="endCall">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="languageDetection">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="transferToAgent">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="transferToNumber">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
        /// <param name="skipTurn">
        /// A system tool is a tool that is used to call a system method in the server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuiltInTools(
            global::G.SystemToolConfigInput? endCall,
            global::G.SystemToolConfigInput? languageDetection,
            global::G.SystemToolConfigInput? transferToAgent,
            global::G.SystemToolConfigInput? transferToNumber,
            global::G.SystemToolConfigInput? skipTurn)
        {
            this.EndCall = endCall;
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.SkipTurn = skipTurn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInTools" /> class.
        /// </summary>
        public BuiltInTools()
        {
        }
    }
}