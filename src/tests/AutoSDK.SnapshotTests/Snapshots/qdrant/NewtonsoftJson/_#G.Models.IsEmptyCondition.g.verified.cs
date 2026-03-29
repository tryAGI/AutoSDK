//HintName: G.Models.IsEmptyCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with empty payload for a specified field
    /// </summary>
    public sealed partial class IsEmptyCondition
    {
        /// <summary>
        /// Payload field
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_empty", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PayloadField IsEmpty { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsEmptyCondition" /> class.
        /// </summary>
        /// <param name="isEmpty">
        /// Payload field
        /// </param>
        public IsEmptyCondition(
            global::G.PayloadField isEmpty)
        {
            this.IsEmpty = isEmpty ?? throw new global::System.ArgumentNullException(nameof(isEmpty));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsEmptyCondition" /> class.
        /// </summary>
        public IsEmptyCondition()
        {
        }
    }
}