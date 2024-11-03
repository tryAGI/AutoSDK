//HintName: G.Models.Cheermote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cheermote
    {
        /// <summary>
        /// The name portion of the Cheermote string that you use in chat to cheer Bits. The full Cheermote string is the concatenation of {prefix} + {number of Bits}. For example, if the prefix is “Cheer” and you want to cheer 100 Bits, the full Cheermote string is Cheer100\. When the Cheermote string is entered in chat, Twitch converts it to the image associated with the Bits tier that was cheered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prefix { get; set; } = default!;

        /// <summary>
        /// A list of tier levels that the Cheermote supports. Each tier identifies the range of Bits that you can cheer at that tier level and an image that graphically identifies the tier level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CheermoteTier> Tiers { get; set; } = default!;

        /// <summary>
        /// The type of Cheermote. Possible values are:  <br/>
        ///   <br/>
        /// * global\_first\_party — A Twitch-defined Cheermote that is shown in the Bits card.<br/>
        /// * global\_third\_party — A Twitch-defined Cheermote that is not shown in the Bits card.<br/>
        /// * channel\_custom — A broadcaster-defined Cheermote.<br/>
        /// * display\_only — Do not use; for internal use only.<br/>
        /// * sponsored — A sponsor-defined Cheermote. When used, the sponsor adds additional Bits to the amount that the user cheered. For example, if the user cheered Terminator100, the broadcaster might receive 110 Bits, which includes the sponsor's 10 Bits contribution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheermoteType Type { get; set; } = default!;

        /// <summary>
        /// The order that the Cheermotes are shown in the Bits card. The numbers may not be consecutive. For example, the numbers may jump from 1 to 7 to 13\. The order numbers are unique within a Cheermote type (for example, global\_first\_party) but may not be unique amongst all Cheermotes in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order", Required = global::Newtonsoft.Json.Required.Always)]
        public int Order { get; set; } = default!;

        /// <summary>
        /// The date and time, in RFC3339 format, when this Cheermote was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdated { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether this Cheermote provides a charitable contribution match during charity campaigns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_charitable", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsCharitable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Cheermote? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Cheermote>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Cheermote?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Cheermote?>(serializer.Deserialize<global::G.Cheermote>(jsonReader));
        }

    }
}