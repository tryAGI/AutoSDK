//HintName: G.Models.ResultSuccessHasPromptsBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessHasPromptsBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPrompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPrompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasPromptsBooleanData" /> class.
        /// </summary>
        /// <param name="hasPrompts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessHasPromptsBooleanData(
            bool hasPrompts)
        {
            this.HasPrompts = hasPrompts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasPromptsBooleanData" /> class.
        /// </summary>
        public ResultSuccessHasPromptsBooleanData()
        {
        }
    }
}