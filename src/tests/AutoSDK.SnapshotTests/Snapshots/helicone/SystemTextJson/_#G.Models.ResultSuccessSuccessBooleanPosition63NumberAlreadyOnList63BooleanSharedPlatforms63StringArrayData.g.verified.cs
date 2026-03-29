//HintName: G.Models.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharedPlatforms")]
        public global::System.Collections.Generic.IList<string>? SharedPlatforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alreadyOnList")]
        public bool? AlreadyOnList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public double? Position { get; set; }

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
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sharedPlatforms"></param>
        /// <param name="alreadyOnList"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData(
            bool success,
            global::System.Collections.Generic.IList<string>? sharedPlatforms,
            bool? alreadyOnList,
            double? position)
        {
            this.SharedPlatforms = sharedPlatforms;
            this.AlreadyOnList = alreadyOnList;
            this.Position = position;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData()
        {
        }
    }
}