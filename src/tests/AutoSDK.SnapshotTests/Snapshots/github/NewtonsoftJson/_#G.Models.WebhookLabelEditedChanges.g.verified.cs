﻿//HintName: G.Models.WebhookLabelEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the label if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookLabelEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public global::G.WebhookLabelEditedChangesColor? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.WebhookLabelEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.WebhookLabelEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        public WebhookLabelEditedChanges(
            global::G.WebhookLabelEditedChangesColor? color,
            global::G.WebhookLabelEditedChangesDescription? description,
            global::G.WebhookLabelEditedChangesName? name)
        {
            this.Color = color;
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        public WebhookLabelEditedChanges()
        {
        }
    }
}