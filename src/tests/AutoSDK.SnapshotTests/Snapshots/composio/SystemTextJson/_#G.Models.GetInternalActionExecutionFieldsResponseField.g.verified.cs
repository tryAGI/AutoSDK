//HintName: G.Models.GetInternalActionExecutionFieldsResponseField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionFieldsResponseField
    {
        /// <summary>
        /// The id of the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The display name of the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The type of the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The regex of the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public string? Regex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionFieldsResponseField" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the field
        /// </param>
        /// <param name="displayName">
        /// The display name of the field
        /// </param>
        /// <param name="type">
        /// The type of the field
        /// </param>
        /// <param name="regex">
        /// The regex of the field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalActionExecutionFieldsResponseField(
            string id,
            string displayName,
            string type,
            string? regex)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Regex = regex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionFieldsResponseField" /> class.
        /// </summary>
        public GetInternalActionExecutionFieldsResponseField()
        {
        }
    }
}