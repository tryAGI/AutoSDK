﻿//HintName: G.Models.PropertySchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
    /// </summary>
    public sealed partial class PropertySchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}