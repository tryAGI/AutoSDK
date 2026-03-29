//HintName: G.Models.CollectionExistence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of existence of a collection, true = exists, false = does not exist
    /// </summary>
    public sealed partial class CollectionExistence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exists", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Exists { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistence" /> class.
        /// </summary>
        /// <param name="exists"></param>
        public CollectionExistence(
            bool exists)
        {
            this.Exists = exists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistence" /> class.
        /// </summary>
        public CollectionExistence()
        {
        }
    }
}