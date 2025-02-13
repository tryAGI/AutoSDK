﻿//HintName: G.Models.IssuesSetLabelsRequestVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesSetLabelsRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant3Label>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSetLabelsRequestVariant3" /> class.
        /// </summary>
        /// <param name="labels"></param>
        public IssuesSetLabelsRequestVariant3(
            global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant3Label>? labels)
        {
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSetLabelsRequestVariant3" /> class.
        /// </summary>
        public IssuesSetLabelsRequestVariant3()
        {
        }
    }
}