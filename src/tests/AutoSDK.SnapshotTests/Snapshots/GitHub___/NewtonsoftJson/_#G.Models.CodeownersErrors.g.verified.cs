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
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodeownersErrorsError> Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeownersErrors" /> class.
        /// </summary>
        /// <param name="errors"></param>
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