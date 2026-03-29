//HintName: G.Models.ErrorError1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorError1
    {
        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Machine-readable error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="code">
        /// Machine-readable error code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorError1(
            string? message,
            string? code)
        {
            this.Message = message;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError1" /> class.
        /// </summary>
        public ErrorError1()
        {
        }
    }
}