//HintName: G.Models.IsNullCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with null payload for a specified field
    /// </summary>
    public sealed partial class IsNullCondition
    {
        /// <summary>
        /// Payload field
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_null", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PayloadField IsNull { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsNullCondition" /> class.
        /// </summary>
        /// <param name="isNull">
        /// Payload field
        /// </param>
        public IsNullCondition(
            global::G.PayloadField isNull)
        {
            this.IsNull = isNull ?? throw new global::System.ArgumentNullException(nameof(isNull));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsNullCondition" /> class.
        /// </summary>
        public IsNullCondition()
        {
        }
    }
}