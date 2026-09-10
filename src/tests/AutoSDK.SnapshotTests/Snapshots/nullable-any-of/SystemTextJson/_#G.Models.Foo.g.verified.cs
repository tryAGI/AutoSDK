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
        [global::System.Text.Json.Serialization.JsonPropertyName("classRef")]
        public global::G.FooClassRef? ClassRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enumRef")]
        public global::G.FooEnumRef? EnumRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneOfClassRef")]
        public global::G.FooClassRef? OneOfClassRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline")]
        public global::G.FooInline? Inline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anyOfItems")]
        public global::System.Collections.Generic.IList<global::G.FooClassRef?>? AnyOfItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneOfItems")]
        public global::System.Collections.Generic.IList<global::G.FooClassRef?>? OneOfItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo" /> class.
        /// </summary>
        /// <param name="classRef"></param>
        /// <param name="enumRef"></param>
        /// <param name="oneOfClassRef"></param>
        /// <param name="inline"></param>
        /// <param name="anyOfItems"></param>
        /// <param name="oneOfItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Foo(
            global::G.FooClassRef? classRef,
            global::G.FooEnumRef? enumRef,
            global::G.FooClassRef? oneOfClassRef,
            global::G.FooInline? inline,
            global::System.Collections.Generic.IList<global::G.FooClassRef?>? anyOfItems,
            global::System.Collections.Generic.IList<global::G.FooClassRef?>? oneOfItems)
        {
            this.ClassRef = classRef;
            this.EnumRef = enumRef;
            this.OneOfClassRef = oneOfClassRef;
            this.Inline = inline;
            this.AnyOfItems = anyOfItems;
            this.OneOfItems = oneOfItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo" /> class.
        /// </summary>
        public Foo()
        {
        }

    }
}