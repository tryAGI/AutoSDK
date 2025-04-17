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
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loss_function")]
        public object? LossFunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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