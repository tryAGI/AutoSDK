﻿//HintName: G.Models.LabeledIssueEventLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledIssueEventLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledIssueEventLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public LabeledIssueEventLabel(
            string name,
            string color)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledIssueEventLabel" /> class.
        /// </summary>
        public LabeledIssueEventLabel()
        {
        }
    }
}