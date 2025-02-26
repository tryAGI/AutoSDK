//HintName: G.Models.SucceededResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SucceededResult
    {
        /// <summary>
        /// Default Value: succeeded
        /// </summary>
        /// <default>global::G.SucceededResultType.Succeeded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SucceededResultTypeJsonConverter))]
        public global::G.SucceededResultType Type { get; set; } = global::G.SucceededResultType.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Message Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SucceededResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: succeeded
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SucceededResult(
            global::G.Message message,
            global::G.SucceededResultType type = global::G.SucceededResultType.Succeeded)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SucceededResult" /> class.
        /// </summary>
        public SucceededResult()
        {
        }
    }
}