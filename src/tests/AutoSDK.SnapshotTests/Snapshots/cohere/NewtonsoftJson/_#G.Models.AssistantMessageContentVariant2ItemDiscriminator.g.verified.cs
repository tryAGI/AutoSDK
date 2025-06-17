﻿//HintName: G.Models.AssistantMessageContentVariant2ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AssistantMessageContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public AssistantMessageContentVariant2ItemDiscriminator(
            global::G.AssistantMessageContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public AssistantMessageContentVariant2ItemDiscriminator()
        {
        }
    }
}