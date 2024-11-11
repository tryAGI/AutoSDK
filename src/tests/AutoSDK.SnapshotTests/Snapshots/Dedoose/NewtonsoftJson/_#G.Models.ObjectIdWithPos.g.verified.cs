//HintName: G.Models.ObjectIdWithPos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectIdWithPos
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIdWithPos" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="position"></param>
        public ObjectIdWithPos(
            global::System.Guid? id,
            int? position)
        {
            this.Id = id;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectIdWithPos" /> class.
        /// </summary>
        public ObjectIdWithPos()
        {
        }
    }
}