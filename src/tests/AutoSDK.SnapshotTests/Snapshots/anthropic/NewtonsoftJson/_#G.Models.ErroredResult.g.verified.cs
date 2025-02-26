//HintName: G.Models.ErroredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErroredResult
    {
        /// <summary>
        /// Default Value: errored
        /// </summary>
        /// <default>global::G.ErroredResultType.Errored</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ErroredResultType Type { get; set; } = global::G.ErroredResultType.Errored;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ErrorResponse Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErroredResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: errored
        /// </param>
        /// <param name="error"></param>
        public ErroredResult(
            global::G.ErrorResponse error,
            global::G.ErroredResultType type = global::G.ErroredResultType.Errored)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErroredResult" /> class.
        /// </summary>
        public ErroredResult()
        {
        }
    }
}