//HintName: G.Models.CheermoteTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheermoteTier
    {
        /// <summary>
        /// The minimum number of Bits that you must cheer at this tier level. The maximum number of Bits that you can cheer at this level is determined by the required minimum Bits of the next tier level minus 1\. For example, if `min_bits` is 1 and `min_bits` for the next tier is 100, the Bits range for this tier level is 1 through 99\. The minimum Bits value of the last tier is the maximum number of Bits you can cheer using this Cheermote. For example, 10000.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_bits", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinBits { get; set; } = default!;

        /// <summary>
        /// The tier level. Possible tiers are:  <br/>
        ///   <br/>
        /// * 1<br/>
        /// * 100<br/>
        /// * 500<br/>
        /// * 1000<br/>
        /// * 5000<br/>
        /// * 10000<br/>
        /// * 100000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheermoteTierId Id { get; set; } = default!;

        /// <summary>
        /// The hex code of the color associated with this tier level (for example, #979797).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CheermoteImages Images { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether users can cheer at this tier level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_cheer", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanCheer { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether this tier level is shown in the Bits card. Is **true** if this tier level is shown in the Bits card.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_in_bits_card", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ShowInBitsCard { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteTier" /> class.
        /// </summary>
        /// <param name="minBits">
        /// The minimum number of Bits that you must cheer at this tier level. The maximum number of Bits that you can cheer at this level is determined by the required minimum Bits of the next tier level minus 1\. For example, if `min_bits` is 1 and `min_bits` for the next tier is 100, the Bits range for this tier level is 1 through 99\. The minimum Bits value of the last tier is the maximum number of Bits you can cheer using this Cheermote. For example, 10000.
        /// </param>
        /// <param name="id">
        /// The tier level. Possible tiers are:  <br/>
        ///   <br/>
        /// * 1<br/>
        /// * 100<br/>
        /// * 500<br/>
        /// * 1000<br/>
        /// * 5000<br/>
        /// * 10000<br/>
        /// * 100000
        /// </param>
        /// <param name="color">
        /// The hex code of the color associated with this tier level (for example, #979797).
        /// </param>
        /// <param name="images"></param>
        /// <param name="canCheer">
        /// A Boolean value that determines whether users can cheer at this tier level.
        /// </param>
        /// <param name="showInBitsCard">
        /// A Boolean value that determines whether this tier level is shown in the Bits card. Is **true** if this tier level is shown in the Bits card.
        /// </param>
        public CheermoteTier(
            int minBits,
            global::G.CheermoteTierId id,
            string color,
            global::G.CheermoteImages images,
            bool canCheer,
            bool showInBitsCard)
        {
            this.MinBits = minBits;
            this.Id = id;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.CanCheer = canCheer;
            this.ShowInBitsCard = showInBitsCard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheermoteTier" /> class.
        /// </summary>
        public CheermoteTier()
        {
        }


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
        public static global::G.CheermoteTier? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheermoteTier>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CheermoteTier?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CheermoteTier?>(serializer.Deserialize<global::G.CheermoteTier>(jsonReader));
        }

    }
}