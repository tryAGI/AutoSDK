//HintName: G.Models.InsertDatasetEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dataset event
    /// </summary>
    public sealed partial class InsertDatasetEvent
    {
        /// <summary>
        /// The argument that uniquely define an input case (an arbitrary, JSON serializable object)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The output of your application, including post-processing (an arbitrary, JSON serializable object)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected")]
        public object? Expected { get; set; }

        /// <summary>
        /// A dictionary with additional data about the test example, model outputs, or just about anything else that's relevant, that you can use to help find and analyze examples later. For example, you could log the `prompt`, example's `id`, or anything else that would be useful to slice/dice later. The values in `metadata` can be any JSON-serializable type, but its keys must be strings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.InsertDatasetEventMetadata? Metadata { get; set; }

        /// <summary>
        /// A list of tags to log
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// A unique identifier for the dataset event. If you don't provide one, Braintrust will generate one for you
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The timestamp the dataset event was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Indicates the event was copied from another object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin")]
        public global::G.ObjectReferenceNullish? Origin { get; set; }

        /// <summary>
        /// Facets for categorization (dictionary from facet id to value)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("facets")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Facets { get; set; }

        /// <summary>
        /// Pass `_object_delete=true` to mark the dataset event deleted. Deleted events will not show up in subsequent fetches for this dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_object_delete")]
        public bool? ObjectDelete { get; set; }

        /// <summary>
        /// The `_is_merge` field controls how the row is merged with any existing row with the same id in the DB. By default (or when set to `false`), the existing row is completely replaced by the new row. When set to `true`, the new row is deep-merged into the existing row, if one is found. If no existing row is found, the new row is inserted as is.<br/>
        /// For example, say there is an existing row in the DB `{"id": "foo", "input": {"a": 5, "b": 10}}`. If we merge a new row as `{"_is_merge": true, "id": "foo", "input": {"b": 11, "c": 20}}`, the new row will be `{"id": "foo", "input": {"a": 5, "b": 11, "c": 20}}`. If we replace the new row as `{"id": "foo", "input": {"b": 11, "c": 20}}`, the new row will be `{"id": "foo", "input": {"b": 11, "c": 20}}`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_is_merge")]
        public bool? IsMerge { get; set; }

        /// <summary>
        /// The `_merge_paths` field allows controlling the depth of the merge, when `_is_merge=true`. `_merge_paths` is a list of paths, where each path is a list of field names. The deep merge will not descend below any of the specified merge paths.<br/>
        /// For example, say there is an existing row in the DB `{"id": "foo", "input": {"a": {"b": 10}, "c": {"d": 20}}, "output": {"a": 20}}`. If we merge a new row as `{"_is_merge": true, "_merge_paths": [["input", "a"], ["output"]], "input": {"a": {"q": 30}, "c": {"e": 30}, "bar": "baz"}, "output": {"d": 40}}`, the new row will be `{"id": "foo": "input": {"a": {"q": 30}, "c": {"d": 20, "e": 30}, "bar": "baz"}, "output": {"d": 40}}`. In this case, due to the merge paths, we have replaced `input.a` and `output`, but have still deep-merged `input` and `input.c`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_merge_paths")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? MergePaths { get; set; }

        /// <summary>
        /// The `_array_delete` field allows removing specific values from array fields. It is an array of objects with `path` and `delete` properties.<br/>
        /// For example, to remove tags "foo" and "bar" from an existing row: `{"_is_merge": true, "_array_delete": [{"path": ["tags"], "delete": ["foo", "bar"]}]}`. For nested fields like `metadata.categories`, use `[{"path": ["metadata", "categories"], "delete": ["value"]}]`. This will remove those specific values from the array while preserving others.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_array_delete")]
        public global::System.Collections.Generic.IList<global::G.InsertDatasetEventArrayDeleteItem>? ArrayDelete { get; set; }

        /// <summary>
        /// DEPRECATED: The `_parent_id` field is deprecated and should not be used. Support for `_parent_id` will be dropped in a future version of Braintrust. Log `span_id`, `root_span_id`, and `span_parents` explicitly instead.<br/>
        /// Use the `_parent_id` field to create this row as a subspan of an existing row. Tracking hierarchical relationships are important for tracing (see the [guide](https://www.braintrust.dev/docs/instrument) for full details).<br/>
        /// For example, say we have logged a row `{"id": "abc", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"_parent_id": "abc", "id": "llm_call", "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root_span_id")]
        public string? RootSpanId { get; set; }

        /// <summary>
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_parents")]
        public global::System.Collections.Generic.IList<string>? SpanParents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEvent" /> class.
        /// </summary>
        /// <param name="input">
        /// The argument that uniquely define an input case (an arbitrary, JSON serializable object)
        /// </param>
        /// <param name="expected">
        /// The output of your application, including post-processing (an arbitrary, JSON serializable object)
        /// </param>
        /// <param name="metadata">
        /// A dictionary with additional data about the test example, model outputs, or just about anything else that's relevant, that you can use to help find and analyze examples later. For example, you could log the `prompt`, example's `id`, or anything else that would be useful to slice/dice later. The values in `metadata` can be any JSON-serializable type, but its keys must be strings
        /// </param>
        /// <param name="tags">
        /// A list of tags to log
        /// </param>
        /// <param name="id">
        /// A unique identifier for the dataset event. If you don't provide one, Braintrust will generate one for you
        /// </param>
        /// <param name="created">
        /// The timestamp the dataset event was created
        /// </param>
        /// <param name="origin">
        /// Indicates the event was copied from another object.
        /// </param>
        /// <param name="facets">
        /// Facets for categorization (dictionary from facet id to value)
        /// </param>
        /// <param name="objectDelete">
        /// Pass `_object_delete=true` to mark the dataset event deleted. Deleted events will not show up in subsequent fetches for this dataset
        /// </param>
        /// <param name="isMerge">
        /// The `_is_merge` field controls how the row is merged with any existing row with the same id in the DB. By default (or when set to `false`), the existing row is completely replaced by the new row. When set to `true`, the new row is deep-merged into the existing row, if one is found. If no existing row is found, the new row is inserted as is.<br/>
        /// For example, say there is an existing row in the DB `{"id": "foo", "input": {"a": 5, "b": 10}}`. If we merge a new row as `{"_is_merge": true, "id": "foo", "input": {"b": 11, "c": 20}}`, the new row will be `{"id": "foo", "input": {"a": 5, "b": 11, "c": 20}}`. If we replace the new row as `{"id": "foo", "input": {"b": 11, "c": 20}}`, the new row will be `{"id": "foo", "input": {"b": 11, "c": 20}}`
        /// </param>
        /// <param name="mergePaths">
        /// The `_merge_paths` field allows controlling the depth of the merge, when `_is_merge=true`. `_merge_paths` is a list of paths, where each path is a list of field names. The deep merge will not descend below any of the specified merge paths.<br/>
        /// For example, say there is an existing row in the DB `{"id": "foo", "input": {"a": {"b": 10}, "c": {"d": 20}}, "output": {"a": 20}}`. If we merge a new row as `{"_is_merge": true, "_merge_paths": [["input", "a"], ["output"]], "input": {"a": {"q": 30}, "c": {"e": 30}, "bar": "baz"}, "output": {"d": 40}}`, the new row will be `{"id": "foo": "input": {"a": {"q": 30}, "c": {"d": 20, "e": 30}, "bar": "baz"}, "output": {"d": 40}}`. In this case, due to the merge paths, we have replaced `input.a` and `output`, but have still deep-merged `input` and `input.c`.
        /// </param>
        /// <param name="arrayDelete">
        /// The `_array_delete` field allows removing specific values from array fields. It is an array of objects with `path` and `delete` properties.<br/>
        /// For example, to remove tags "foo" and "bar" from an existing row: `{"_is_merge": true, "_array_delete": [{"path": ["tags"], "delete": ["foo", "bar"]}]}`. For nested fields like `metadata.categories`, use `[{"path": ["metadata", "categories"], "delete": ["value"]}]`. This will remove those specific values from the array while preserving others.
        /// </param>
        /// <param name="parentId">
        /// DEPRECATED: The `_parent_id` field is deprecated and should not be used. Support for `_parent_id` will be dropped in a future version of Braintrust. Log `span_id`, `root_span_id`, and `span_parents` explicitly instead.<br/>
        /// Use the `_parent_id` field to create this row as a subspan of an existing row. Tracking hierarchical relationships are important for tracing (see the [guide](https://www.braintrust.dev/docs/instrument) for full details).<br/>
        /// For example, say we have logged a row `{"id": "abc", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"_parent_id": "abc", "id": "llm_call", "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </param>
        /// <param name="spanId">
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </param>
        /// <param name="rootSpanId">
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </param>
        /// <param name="spanParents">
        /// Use `span_id`, `root_span_id`, and `span_parents` instead of `_parent_id`, which is now deprecated. The span_id is a unique identifier describing the row's place in the a trace, and the root_span_id is a unique identifier for the whole trace. See the [guide](https://www.braintrust.dev/docs/instrument) for full details.<br/>
        /// For example, say we have logged a row `{"id": "abc", "span_id": "span0", "root_span_id": "root_span0", "input": "foo", "output": "bar", "expected": "boo", "scores": {"correctness": 0.33}}`. We can create a sub-span of the parent row by logging `{"id": "llm_call", "span_id": "span1", "root_span_id": "root_span0", "span_parents": ["span0"], "input": {"prompt": "What comes after foo?"}, "output": "bar", "metrics": {"tokens": 1}}`. In the webapp, only the root span row `"abc"` will show up in the summary view. You can view the full trace hierarchy (in this case, the `"llm_call"` row) by clicking on the "abc" row.<br/>
        /// If the row is being merged into an existing row, this field will be ignored.
        /// </param>
        public InsertDatasetEvent(
            object? input,
            object? expected,
            global::G.InsertDatasetEventMetadata? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            string? id,
            global::System.DateTime? created,
            global::G.ObjectReferenceNullish? origin,
            global::System.Collections.Generic.Dictionary<string, object?>? facets,
            bool? objectDelete,
            bool? isMerge,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? mergePaths,
            global::System.Collections.Generic.IList<global::G.InsertDatasetEventArrayDeleteItem>? arrayDelete,
            string? parentId,
            string? spanId,
            string? rootSpanId,
            global::System.Collections.Generic.IList<string>? spanParents)
        {
            this.Input = input;
            this.Expected = expected;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Id = id;
            this.Created = created;
            this.Origin = origin;
            this.Facets = facets;
            this.ObjectDelete = objectDelete;
            this.IsMerge = isMerge;
            this.MergePaths = mergePaths;
            this.ArrayDelete = arrayDelete;
            this.ParentId = parentId;
            this.SpanId = spanId;
            this.RootSpanId = rootSpanId;
            this.SpanParents = spanParents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetEvent" /> class.
        /// </summary>
        public InsertDatasetEvent()
        {
        }
    }
}