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
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Required { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredConstraint" /> class.
        /// </summary>
        /// <param name="required"></param>
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