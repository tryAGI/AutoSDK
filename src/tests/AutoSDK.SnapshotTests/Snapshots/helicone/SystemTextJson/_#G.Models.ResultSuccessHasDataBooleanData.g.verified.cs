//HintName: G.Models.ResultSuccessHasDataBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessHasDataBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasDataBooleanData" /> class.
        /// </summary>
        /// <param name="hasData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessHasDataBooleanData(
            bool hasData)
        {
            this.HasData = hasData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasDataBooleanData" /> class.
        /// </summary>
        public ResultSuccessHasDataBooleanData()
        {
        }
    }
}