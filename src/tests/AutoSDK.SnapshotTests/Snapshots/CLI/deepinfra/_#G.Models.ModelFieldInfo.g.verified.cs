//HintName: G.Models.ModelFieldInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelFieldInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public string? Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ftype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ftype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        public global::System.Collections.Generic.IList<object>? Allowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<object>? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMinimum")]
        public double? ExclusiveMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveMaximum")]
        public double? ExclusiveMaximum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFieldInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        /// <param name="ftype"></param>
        /// <param name="description"></param>
        /// <param name="allowed"></param>
        /// <param name="default"></param>
        /// <param name="examples">
        /// Default Value: []
        /// </param>
        /// <param name="minimum"></param>
        /// <param name="exclusiveMinimum"></param>
        /// <param name="maximum"></param>
        /// <param name="exclusiveMaximum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelFieldInfo(
            string name,
            string ftype,
            string? parent,
            string? description,
            global::System.Collections.Generic.IList<object>? allowed,
            object? @default,
            global::System.Collections.Generic.IList<object>? examples,
            double? minimum,
            double? exclusiveMinimum,
            double? maximum,
            double? exclusiveMaximum)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Ftype = ftype ?? throw new global::System.ArgumentNullException(nameof(ftype));
            this.Parent = parent;
            this.Description = description;
            this.Allowed = allowed;
            this.Default = @default;
            this.Examples = examples;
            this.Minimum = minimum;
            this.ExclusiveMinimum = exclusiveMinimum;
            this.Maximum = maximum;
            this.ExclusiveMaximum = exclusiveMaximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFieldInfo" /> class.
        /// </summary>
        public ModelFieldInfo()
        {
        }
    }
}