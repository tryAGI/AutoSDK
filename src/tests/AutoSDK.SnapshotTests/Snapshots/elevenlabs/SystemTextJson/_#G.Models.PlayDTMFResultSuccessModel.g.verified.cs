//HintName: G.Models.PlayDTMFResultSuccessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlayDTMFResultSuccessModel
    {
        /// <summary>
        /// Default Value: play_dtmf_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmf_tones")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DtmfTones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFResultSuccessModel" /> class.
        /// </summary>
        /// <param name="dtmfTones"></param>
        /// <param name="resultType">
        /// Default Value: play_dtmf_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayDTMFResultSuccessModel(
            string dtmfTones,
            string? resultType,
            string? status,
            string? reason)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.DtmfTones = dtmfTones ?? throw new global::System.ArgumentNullException(nameof(dtmfTones));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFResultSuccessModel" /> class.
        /// </summary>
        public PlayDTMFResultSuccessModel()
        {
        }
    }
}