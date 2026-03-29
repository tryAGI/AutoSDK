//HintName: G.Models.LastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LastError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Msg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LastError(
            int code,
            string msg)
        {
            this.Code = code;
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastError" /> class.
        /// </summary>
        public LastError()
        {
        }
    }
}