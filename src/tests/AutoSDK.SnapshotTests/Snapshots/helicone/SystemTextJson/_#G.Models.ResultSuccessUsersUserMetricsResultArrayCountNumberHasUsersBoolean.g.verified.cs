//HintName: G.Models.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public double? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean(
            global::G.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData data,
            double? error)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean" /> class.
        /// </summary>
        public ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBoolean()
        {
        }
    }
}