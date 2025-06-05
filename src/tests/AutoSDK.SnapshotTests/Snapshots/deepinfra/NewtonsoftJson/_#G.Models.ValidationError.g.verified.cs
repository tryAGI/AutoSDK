﻿//HintName: G.Models.ValidationError.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loc", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<string, int?>> Loc { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg", Required = global::Newtonsoft.Json.Required.Always)]
        public string Msg { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        public ValidationError(
            global::System.Collections.Generic.IList<global::G.AnyOf<string, int?>> loc,
            string msg,
            string type)
        {
            this.Loc = loc ?? throw new global::System.ArgumentNullException(nameof(loc));
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        public ValidationError()
        {
        }
    }
}