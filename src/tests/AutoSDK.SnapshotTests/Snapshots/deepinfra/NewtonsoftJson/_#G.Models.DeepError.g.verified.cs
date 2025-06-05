//HintName: G.Models.DeepError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeepError
    {
        /// <summary>
        /// Error<br/>
        /// Example: Model not found
        /// </summary>
        /// <example>Model not found</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error<br/>
        /// Example: Model not found
        /// </param>
        public DeepError(
            string error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepError" /> class.
        /// </summary>
        public DeepError()
        {
        }
    }
}