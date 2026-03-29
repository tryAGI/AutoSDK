//HintName: G.Models.ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newPosition")]
        public double? NewPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="success"></param>
        /// <param name="newPosition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData(
            string message,
            bool success,
            double? newPosition)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.NewPosition = newPosition;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanNewPosition63NumberMessageStringData()
        {
        }
    }
}