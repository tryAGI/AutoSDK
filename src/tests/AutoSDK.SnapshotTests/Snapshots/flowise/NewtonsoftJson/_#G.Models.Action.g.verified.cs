//HintName: G.Models.Action.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Action
    {
        /// <summary>
        /// Example: 61beeb58-6ebe-4d51-aa0b-41d4c546ff08
        /// </summary>
        /// <example>61beeb58-6ebe-4d51-aa0b-41d4c546ff08</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mapping")]
        public global::G.ActionMapping? Mapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elements")]
        public byte[]? Elements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 61beeb58-6ebe-4d51-aa0b-41d4c546ff08
        /// </param>
        /// <param name="mapping"></param>
        /// <param name="elements"></param>
        public Action(
            global::System.Guid? id,
            global::G.ActionMapping? mapping,
            byte[]? elements)
        {
            this.Id = id;
            this.Mapping = mapping;
            this.Elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        public Action()
        {
        }
    }
}