//HintName: G.Models.FooClassRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FooClassRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personId")]
        public long? PersonId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FooClassRef" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="personId"></param>
        public FooClassRef(
            string? label,
            long? personId)
        {
            this.Label = label;
            this.PersonId = personId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FooClassRef" /> class.
        /// </summary>
        public FooClassRef()
        {
        }

    }
}