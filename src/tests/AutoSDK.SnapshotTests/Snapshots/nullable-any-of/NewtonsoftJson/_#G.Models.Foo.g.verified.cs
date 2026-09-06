//HintName: G.Models.Foo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Foo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classRef")]
        public global::G.FooClassRef? ClassRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enumRef")]
        public global::G.FooEnumRef? EnumRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oneOfClassRef")]
        public global::G.FooClassRef? OneOfClassRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inline")]
        public global::G.FooInline? Inline { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo" /> class.
        /// </summary>
        /// <param name="classRef"></param>
        /// <param name="enumRef"></param>
        /// <param name="oneOfClassRef"></param>
        /// <param name="inline"></param>
        public Foo(
            global::G.FooClassRef? classRef,
            global::G.FooEnumRef? enumRef,
            global::G.FooClassRef? oneOfClassRef,
            global::G.FooInline? inline)
        {
            this.ClassRef = classRef;
            this.EnumRef = enumRef;
            this.OneOfClassRef = oneOfClassRef;
            this.Inline = inline;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo" /> class.
        /// </summary>
        public Foo()
        {
        }

    }
}