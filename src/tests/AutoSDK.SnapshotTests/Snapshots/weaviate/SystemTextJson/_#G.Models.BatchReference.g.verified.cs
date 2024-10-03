//HintName: G.Models.BatchReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchReference
    {
        /// <summary>
        /// Long-form beacon-style URI to identify the source of the cross-ref including the property name. Should be in the form of weaviate://localhost/&lt;kinds&gt;/&lt;uuid&gt;/&lt;className&gt;/&lt;propertyName&gt;, where &lt;kinds&gt; must be one of 'objects', 'objects' and &lt;className&gt; and &lt;propertyName&gt; must represent the cross-ref property of source class to be used.<br/>
        /// Example: weaviate://localhost/Zoo/a5d09582-4239-4702-81c9-92a6e0122bb4/hasAnimals
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Short-form URI to point to the cross-ref. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object<br/>
        /// Example: weaviate://localhost/97525810-a9a5-4eb0-858a-71449aeb007f
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Name of the reference tenant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}