//HintName: G.Models.ValidationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationError
    {
        /// <summary>
        /// Location of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<string, int?>> Loc { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Msg { get; set; }

        /// <summary>
        /// Error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="loc">
        /// Location of the error.
        /// </param>
        /// <param name="msg">
        /// Error message.
        /// </param>
        /// <param name="type">
        /// Error type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationError(
            global::System.Collections.Generic.IList<global::G.OneOf<string, int?>> loc,
            string msg,
            string type)
        {
            this.Loc = loc ?? throw new global::System.ArgumentNullException(nameof(loc));
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        public ValidationError()
        {
        }
    }
}