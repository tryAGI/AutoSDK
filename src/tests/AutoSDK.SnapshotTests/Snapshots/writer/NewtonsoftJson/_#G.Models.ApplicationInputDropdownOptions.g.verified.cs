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
        [global::Newtonsoft.Json.JsonProperty("list", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> List { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputDropdownOptions" /> class.
        /// </summary>
        /// <param name="list">
        /// List of available options in the dropdown menu.
        /// </param>
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