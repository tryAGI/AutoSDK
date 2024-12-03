//HintName: G.Models.DependabotAlertPackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the vulnerable package.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertPackage
    {
        /// <summary>
        /// The package's language or package management ecosystem.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        public string Ecosystem { get; set; } = default!;

        /// <summary>
        /// The unique package name within its ecosystem.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertPackage" /> class.
        /// </summary>
        /// <param name="ecosystem">
        /// The package's language or package management ecosystem.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The unique package name within its ecosystem.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependabotAlertPackage(
            string ecosystem = default!,
            string name = default!)
        {
            this.Ecosystem = ecosystem;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertPackage" /> class.
        /// </summary>
        public DependabotAlertPackage()
        {
        }
    }
}