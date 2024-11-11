//HintName: G.Models.Property.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Property
    {
        /// <summary>
        /// Data type of the property. If it starts with a capital (for example Person), may be a reference to another type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DataTypeItem> DataType { get; set; } = default!;

        /// <summary>
        /// Description of the property for documentation purposes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Configuration specific to modules in a property context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moduleConfig")]
        public global::G.PropertyModuleConfig? ModuleConfig { get; set; }

        /// <summary>
        /// The name of the property. Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// (Deprecated) Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexInverted")]
        public bool? IndexInverted { get; set; }

        /// <summary>
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexFilterable")]
        public bool? IndexFilterable { get; set; }

        /// <summary>
        /// Whether to include this property in the searchable, inverted index. Applicable only to properties of data type text and text[]. If `false`, this property cannot be used in `bm25` or `hybrid` searches. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexSearchable")]
        public bool? IndexSearchable { get; set; }

        /// <summary>
        /// Whether to include this property in the filterable, range-based Roaring Bitmap inverted index. Defaults to false. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexRangeFilters")]
        public bool? IndexRangeFilters { get; set; }

        /// <summary>
        /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
        /// Default Value: word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenization")]
        public global::G.Tokenization? Tokenization { get; set; }

        /// <summary>
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nestedProperties")]
        public global::System.Collections.Generic.IList<global::G.NestedProperty>? NestedProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        /// <param name="dataType">
        /// Data type of the property. If it starts with a capital (for example Person), may be a reference to another type.
        /// </param>
        /// <param name="description">
        /// Description of the property for documentation purposes.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a property context.
        /// </param>
        /// <param name="name">
        /// The name of the property. Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </param>
        /// <param name="indexInverted">
        /// (Deprecated) Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexFilterable">
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexSearchable">
        /// Whether to include this property in the searchable, inverted index. Applicable only to properties of data type text and text[]. If `false`, this property cannot be used in `bm25` or `hybrid` searches. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexRangeFilters">
        /// Whether to include this property in the filterable, range-based Roaring Bitmap inverted index. Defaults to false. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </param>
        /// <param name="tokenization">
        /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
        public Property(
            global::System.Collections.Generic.IList<global::G.DataTypeItem> dataType,
            string name,
            string? description,
            global::G.PropertyModuleConfig? moduleConfig,
            bool? indexInverted,
            bool? indexFilterable,
            bool? indexSearchable,
            bool? indexRangeFilters,
            global::G.Tokenization? tokenization,
            global::System.Collections.Generic.IList<global::G.NestedProperty>? nestedProperties)
        {
            this.DataType = dataType ?? throw new global::System.ArgumentNullException(nameof(dataType));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ModuleConfig = moduleConfig;
            this.IndexInverted = indexInverted;
            this.IndexFilterable = indexFilterable;
            this.IndexSearchable = indexSearchable;
            this.IndexRangeFilters = indexRangeFilters;
            this.Tokenization = tokenization;
            this.NestedProperties = nestedProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        public Property()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Property? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Property>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Property?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Property?>(serializer.Deserialize<global::G.Property>(jsonReader));
        }

    }
}