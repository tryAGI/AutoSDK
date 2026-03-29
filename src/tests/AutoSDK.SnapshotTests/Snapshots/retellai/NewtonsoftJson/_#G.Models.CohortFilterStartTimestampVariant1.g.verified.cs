//HintName: G.Models.CohortFilterStartTimestampVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortFilterStartTimestampVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op")]
        public global::G.CohortFilterStartTimestampVariant1Op? Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterStartTimestampVariant1" /> class.
        /// </summary>
        /// <param name="op"></param>
        public CohortFilterStartTimestampVariant1(
            global::G.CohortFilterStartTimestampVariant1Op? op)
        {
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilterStartTimestampVariant1" /> class.
        /// </summary>
        public CohortFilterStartTimestampVariant1()
        {
        }
    }
}