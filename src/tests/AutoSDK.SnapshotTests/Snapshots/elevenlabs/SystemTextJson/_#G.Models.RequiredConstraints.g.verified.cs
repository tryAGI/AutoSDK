//HintName: G.Models.RequiredConstraints.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Wrapper for anyOf/allOf composition constraints scoped to required fields.
    /// </summary>
    public sealed partial class RequiredConstraints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_of")]
        public global::System.Collections.Generic.IList<global::G.RequiredConstraint>? AnyOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        public global::System.Collections.Generic.IList<global::G.RequiredConstraint>? AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredConstraints" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
        /// <param name="allOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequiredConstraints(
            global::System.Collections.Generic.IList<global::G.RequiredConstraint>? anyOf,
            global::System.Collections.Generic.IList<global::G.RequiredConstraint>? allOf)
        {
            this.AnyOf = anyOf;
            this.AllOf = allOf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredConstraints" /> class.
        /// </summary>
        public RequiredConstraints()
        {
        }
    }
}