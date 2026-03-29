//HintName: G.Models.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray(
            global::G.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData data,
            double? error)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArray()
        {
        }
    }
}