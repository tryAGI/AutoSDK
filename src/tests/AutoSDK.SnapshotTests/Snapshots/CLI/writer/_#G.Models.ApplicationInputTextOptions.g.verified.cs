//HintName: G.Models.ApplicationInputTextOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options specific to text input fields.
    /// </summary>
    public sealed partial class ApplicationInputTextOptions
    {
        /// <summary>
        /// Maximum number of text fields allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFields { get; set; }

        /// <summary>
        /// Minimum number of text fields required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputTextOptions" /> class.
        /// </summary>
        /// <param name="maxFields">
        /// Maximum number of text fields allowed.
        /// </param>
        /// <param name="minFields">
        /// Minimum number of text fields required.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationInputTextOptions(
            int maxFields,
            int minFields)
        {
            this.MaxFields = maxFields;
            this.MinFields = minFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputTextOptions" /> class.
        /// </summary>
        public ApplicationInputTextOptions()
        {
        }
    }
}