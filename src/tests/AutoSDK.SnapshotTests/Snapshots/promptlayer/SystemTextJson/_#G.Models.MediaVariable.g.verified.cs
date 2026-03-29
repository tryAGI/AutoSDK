//HintName: G.Models.MediaVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MediaVariable
    {
        /// <summary>
        /// Default Value: media_variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MediaVariableTypeJsonConverter))]
        public global::G.MediaVariableType? Type { get; set; }

        /// <summary>
        /// Name of the media variable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the media variable
        /// </param>
        /// <param name="type">
        /// Default Value: media_variable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaVariable(
            string name,
            global::G.MediaVariableType? type)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVariable" /> class.
        /// </summary>
        public MediaVariable()
        {
        }
    }
}