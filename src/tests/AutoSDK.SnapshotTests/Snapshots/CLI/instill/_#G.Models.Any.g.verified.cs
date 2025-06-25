﻿//HintName: G.Models.Any.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `Any` contains an arbitrary serialized protocol buffer message along with a<br/>
    /// URL that describes the type of the serialized message.<br/>
    /// Protobuf library provides support to pack/unpack Any values in the form<br/>
    /// of utility functions or additional generated methods of the Any type.<br/>
    /// Example 1: Pack and unpack a message in C++.<br/>
    ///     Foo foo = ...;<br/>
    ///     Any any;<br/>
    ///     any.PackFrom(foo);<br/>
    ///     ...<br/>
    ///     if (any.UnpackTo(&amp;foo)) {<br/>
    ///       ...<br/>
    ///     }<br/>
    /// Example 2: Pack and unpack a message in Java.<br/>
    ///     Foo foo = ...;<br/>
    ///     Any any = Any.pack(foo);<br/>
    ///     ...<br/>
    ///     if (any.is(Foo.class)) {<br/>
    ///       foo = any.unpack(Foo.class);<br/>
    ///     }<br/>
    ///     // or ...<br/>
    ///     if (any.isSameTypeAs(Foo.getDefaultInstance())) {<br/>
    ///       foo = any.unpack(Foo.getDefaultInstance());<br/>
    ///     }<br/>
    ///  Example 3: Pack and unpack a message in Python.<br/>
    ///     foo = Foo(...)<br/>
    ///     any = Any()<br/>
    ///     any.Pack(foo)<br/>
    ///     ...<br/>
    ///     if any.Is(Foo.DESCRIPTOR):<br/>
    ///       any.Unpack(foo)<br/>
    ///       ...<br/>
    ///  Example 4: Pack and unpack a message in Go<br/>
    ///      foo := &amp;pb.Foo{...}<br/>
    ///      any, err := anypb.New(foo)<br/>
    ///      if err != nil {<br/>
    ///        ...<br/>
    ///      }<br/>
    ///      ...<br/>
    ///      foo := &amp;pb.Foo{}<br/>
    ///      if err := any.UnmarshalTo(foo); err != nil {<br/>
    ///        ...<br/>
    ///      }<br/>
    /// The pack methods provided by protobuf library will by default use<br/>
    /// 'type.googleapis.com/full.type.name' as the type URL and the unpack<br/>
    /// methods only use the fully qualified type name after the last '/'<br/>
    /// in the type URL, for example "foo.bar.com/x/y.z" will yield type<br/>
    /// name "y.z".<br/>
    /// JSON<br/>
    /// ====<br/>
    /// The JSON representation of an `Any` value uses the regular<br/>
    /// representation of the deserialized, embedded message, with an<br/>
    /// additional field `@type` which contains the type URL. Example:<br/>
    ///     package google.profile;<br/>
    ///     message Person {<br/>
    ///       string first_name = 1;<br/>
    ///       string last_name = 2;<br/>
    ///     }<br/>
    ///     {<br/>
    ///       "@type": "type.googleapis.com/google.profile.Person",<br/>
    ///       "firstName": &lt;string&gt;,<br/>
    ///       "lastName": &lt;string&gt;<br/>
    ///     }<br/>
    /// If the embedded message type is well-known and has a custom JSON<br/>
    /// representation, that representation will be embedded adding a field<br/>
    /// `value` which holds the custom JSON in addition to the `@type`<br/>
    /// field. Example (for message [google.protobuf.Duration][]):<br/>
    ///     {<br/>
    ///       "@type": "type.googleapis.com/google.protobuf.Duration",<br/>
    ///       "value": "1.212s"<br/>
    ///     }
    /// </summary>
    public sealed partial class Any
    {
        /// <summary>
        /// A URL/resource name that uniquely identifies the type of the serialized<br/>
        /// protocol buffer message. This string must contain at least<br/>
        /// one "/" character. The last segment of the URL's path must represent<br/>
        /// the fully qualified name of the type (as in<br/>
        /// `path/google.protobuf.Duration`). The name should be in a canonical form<br/>
        /// (e.g., leading "." is not accepted).<br/>
        /// In practice, teams usually precompile into the binary all types that they<br/>
        /// expect it to use in the context of Any. However, for URLs which use the<br/>
        /// scheme `http`, `https`, or no scheme, one can optionally set up a type<br/>
        /// server that maps type URLs to message definitions as follows:<br/>
        /// * If no scheme is provided, `https` is assumed.<br/>
        /// * An HTTP GET on the URL must yield a [google.protobuf.Type][]<br/>
        ///   value in binary format, or produce an error.<br/>
        /// * Applications are allowed to cache lookup results based on the<br/>
        ///   URL, or have them precompiled into a binary to avoid any<br/>
        ///   lookup. Therefore, binary compatibility needs to be preserved<br/>
        ///   on changes to types. (Use versioned type names to manage<br/>
        ///   breaking changes.)<br/>
        /// Note: this functionality is not currently available in the official<br/>
        /// protobuf release, and it is not used for type URLs beginning with<br/>
        /// type.googleapis.com. As of May 2023, there are no widely used type server<br/>
        /// implementations and no plans to implement one.<br/>
        /// Schemes other than `http`, `https` (or the empty scheme) might be<br/>
        /// used with implementation specific semantics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("@type")]
        public string? x_type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Any" /> class.
        /// </summary>
        /// <param name="x_type">
        /// A URL/resource name that uniquely identifies the type of the serialized<br/>
        /// protocol buffer message. This string must contain at least<br/>
        /// one "/" character. The last segment of the URL's path must represent<br/>
        /// the fully qualified name of the type (as in<br/>
        /// `path/google.protobuf.Duration`). The name should be in a canonical form<br/>
        /// (e.g., leading "." is not accepted).<br/>
        /// In practice, teams usually precompile into the binary all types that they<br/>
        /// expect it to use in the context of Any. However, for URLs which use the<br/>
        /// scheme `http`, `https`, or no scheme, one can optionally set up a type<br/>
        /// server that maps type URLs to message definitions as follows:<br/>
        /// * If no scheme is provided, `https` is assumed.<br/>
        /// * An HTTP GET on the URL must yield a [google.protobuf.Type][]<br/>
        ///   value in binary format, or produce an error.<br/>
        /// * Applications are allowed to cache lookup results based on the<br/>
        ///   URL, or have them precompiled into a binary to avoid any<br/>
        ///   lookup. Therefore, binary compatibility needs to be preserved<br/>
        ///   on changes to types. (Use versioned type names to manage<br/>
        ///   breaking changes.)<br/>
        /// Note: this functionality is not currently available in the official<br/>
        /// protobuf release, and it is not used for type URLs beginning with<br/>
        /// type.googleapis.com. As of May 2023, there are no widely used type server<br/>
        /// implementations and no plans to implement one.<br/>
        /// Schemes other than `http`, `https` (or the empty scheme) might be<br/>
        /// used with implementation specific semantics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Any(
            string? x_type)
        {
            this.x_type = x_type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Any" /> class.
        /// </summary>
        public Any()
        {
        }
    }
}