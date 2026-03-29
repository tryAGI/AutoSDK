//HintName: G.Models.HasVectorCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter points which have specific vector assigned
    /// </summary>
    public sealed partial class HasVectorCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_vector", Required = global::Newtonsoft.Json.Required.Always)]
        public string HasVector { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasVectorCondition" /> class.
        /// </summary>
        /// <param name="hasVector"></param>
        public HasVectorCondition(
            string hasVector)
        {
            this.HasVector = hasVector ?? throw new global::System.ArgumentNullException(nameof(hasVector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasVectorCondition" /> class.
        /// </summary>
        public HasVectorCondition()
        {
        }
    }
}