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
        [global::System.Text.Json.Serialization.JsonPropertyName("min_bits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinBits { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheermoteTierIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheermoteTierId Id { get; set; }

        /// <summary>
        /// The hex code of the color associated with this tier level (for example, #979797).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CheermoteImages Images { get; set; }

        /// <summary>
        /// A Boolean value that determines whether users can cheer at this tier level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_cheer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanCheer { get; set; }

        /// <summary>
        /// A Boolean value that determines whether this tier level is shown in the Bits card. Is **true** if this tier level is shown in the Bits card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_in_bits_card")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShowInBitsCard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CheermoteTier? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CheermoteTier),
                jsonSerializerContext) as global::G.CheermoteTier;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheermoteTier>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CheermoteTier?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CheermoteTier),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CheermoteTier;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CheermoteTier?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}