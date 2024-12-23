﻿//HintName: G.Models.TagValueCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagValueCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueCreate" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="description"></param>
        public TagValueCreate(
            string value,
            string? description)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueCreate" /> class.
        /// </summary>
        public TagValueCreate()
        {
        }
    }
}