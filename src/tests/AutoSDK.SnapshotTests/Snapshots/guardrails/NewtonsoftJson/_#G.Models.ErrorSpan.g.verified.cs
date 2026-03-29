//HintName: G.Models.ErrorSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A span marking an error in the validated text.
    /// </summary>
    public sealed partial class ErrorSpan
    {
        /// <summary>
        /// The start index of the error span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The end index of the error span.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// The reason validation failed, specific to this chunk.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSpan" /> class.
        /// </summary>
        /// <param name="start">
        /// The start index of the error span.
        /// </param>
        /// <param name="end">
        /// The end index of the error span.
        /// </param>
        /// <param name="reason">
        /// The reason validation failed, specific to this chunk.
        /// </param>
        public ErrorSpan(
            int start,
            int end,
            string reason)
        {
            this.Start = start;
            this.End = end;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSpan" /> class.
        /// </summary>
        public ErrorSpan()
        {
        }
    }
}