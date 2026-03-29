//HintName: G.Models.PostInternalTriggerLogsRequestSearchParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalTriggerLogsRequestSearchParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsRequestSearchParam" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operation"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalTriggerLogsRequestSearchParam(
            string? field,
            string? operation,
            string? value)
        {
            this.Field = field;
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalTriggerLogsRequestSearchParam" /> class.
        /// </summary>
        public PostInternalTriggerLogsRequestSearchParam()
        {
        }
    }
}