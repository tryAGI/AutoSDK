//HintName: G.Models.RequiredConstraint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of fields that must all be present to satisfy this constraint.
    /// </summary>
    public sealed partial class RequiredConstraint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredConstraint" /> class.
        /// </summary>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequiredConstraint(
            global::System.Collections.Generic.IList<string> required)
        {
            this.Required = required ?? throw new global::System.ArgumentNullException(nameof(required));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredConstraint" /> class.
        /// </summary>
        public RequiredConstraint()
        {
        }
    }
}