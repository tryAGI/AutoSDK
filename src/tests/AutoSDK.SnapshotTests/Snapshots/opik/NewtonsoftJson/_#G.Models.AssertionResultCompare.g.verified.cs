//HintName: G.Models.AssertionResultCompare.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class AssertionResultCompare
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed")]
        public bool? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultCompare" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="passed"></param>
        /// <param name="reason"></param>
        public AssertionResultCompare(
            string? value,
            bool? passed,
            string? reason)
        {
            this.Value = value;
            this.Passed = passed;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultCompare" /> class.
        /// </summary>
        public AssertionResultCompare()
        {
        }
    }
}