//HintName: G.Models.ApplicationInputDropdownOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options specific to dropdown-type input fields.
    /// </summary>
    public sealed partial class ApplicationInputDropdownOptions
    {
        /// <summary>
        /// List of available options in the dropdown menu.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> List { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputDropdownOptions" /> class.
        /// </summary>
        /// <param name="list">
        /// List of available options in the dropdown menu.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationInputDropdownOptions(
            global::System.Collections.Generic.IList<string> list)
        {
            this.List = list ?? throw new global::System.ArgumentNullException(nameof(list));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputDropdownOptions" /> class.
        /// </summary>
        public ApplicationInputDropdownOptions()
        {
        }
    }
}