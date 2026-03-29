//HintName: G.Models.ExportsCreateResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsCreateResponse2
    {
        /// <summary>
        /// Example: Schema is required and must be a valid object
        /// </summary>
        /// <example>Schema is required and must be a valid object</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Schema is required and must be a valid object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportsCreateResponse2(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponse2" /> class.
        /// </summary>
        public ExportsCreateResponse2()
        {
        }
    }
}