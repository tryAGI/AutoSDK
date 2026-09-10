//HintName: G.Models.Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anyOfItems")]
        public global::System.Collections.Generic.IList<global::G.Word?>? AnyOfItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oneOfItems")]
        public global::System.Collections.Generic.IList<global::G.Word?>? OneOfItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plainItems")]
        public global::System.Collections.Generic.IList<global::G.Word>? PlainItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nullableRef")]
        public global::G.Word? NullableRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="anyOfItems"></param>
        /// <param name="oneOfItems"></param>
        /// <param name="plainItems"></param>
        /// <param name="nullableRef"></param>
        public Event(
            string? type,
            global::System.Collections.Generic.IList<global::G.Word?>? anyOfItems,
            global::System.Collections.Generic.IList<global::G.Word?>? oneOfItems,
            global::System.Collections.Generic.IList<global::G.Word>? plainItems,
            global::G.Word? nullableRef)
        {
            this.Type = type;
            this.AnyOfItems = anyOfItems;
            this.OneOfItems = oneOfItems;
            this.PlainItems = plainItems;
            this.NullableRef = nullableRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }

    }
}