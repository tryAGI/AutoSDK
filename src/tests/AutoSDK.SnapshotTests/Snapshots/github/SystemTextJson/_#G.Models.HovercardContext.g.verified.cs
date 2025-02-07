//HintName: G.Models.HovercardContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HovercardContext
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
        [global::System.Text.Json.Serialization.JsonPropertyName("octicon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Octicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HovercardContext" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="octicon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HovercardContext(
            string message,
            string octicon)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Octicon = octicon ?? throw new global::System.ArgumentNullException(nameof(octicon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HovercardContext" /> class.
        /// </summary>
        public HovercardContext()
        {
        }
    }
}