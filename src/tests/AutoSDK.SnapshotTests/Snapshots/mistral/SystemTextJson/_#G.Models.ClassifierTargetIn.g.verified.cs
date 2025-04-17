//HintName: G.Models.ClassifierTargetIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierTargetIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_function")]
        public object? LossFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetIn" /> class.
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="lossFunction"></param>
        /// <param name="name"></param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierTargetIn(
            global::System.Collections.Generic.IList<string> labels,
            string name,
            object? lossFunction,
            double? weight)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LossFunction = lossFunction;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTargetIn" /> class.
        /// </summary>
        public ClassifierTargetIn()
        {
        }
    }
}