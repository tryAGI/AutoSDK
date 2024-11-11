//HintName: G.Models.CodeownersErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of errors found in a repo's CODEOWNERS file
    /// </summary>
    public sealed partial class CodeownersErrors
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodeownersErrorsError> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeownersErrors" /> class.
        /// </summary>
        /// <param name="errors"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeownersErrors(
            global::System.Collections.Generic.IList<global::G.CodeownersErrorsError> errors)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeownersErrors" /> class.
        /// </summary>
        public CodeownersErrors()
        {
        }
    }
}