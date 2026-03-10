//HintName: G.JsonConverters.BranchInfoVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BranchInfoVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BranchInfoVariant1>
    {
        /// <inheritdoc />
        public override global::G.BranchInfoVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TransferBranchInfoTrafficSplit? trafficSplit = default;
            if (discriminator?.BranchReason == global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.TrafficSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferBranchInfoTrafficSplit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferBranchInfoTrafficSplit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferBranchInfoTrafficSplit)}");
                trafficSplit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TransferBranchInfoDefaultingToMain? defaultingToMain = default;
            if (discriminator?.BranchReason == global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.DefaultingToMain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferBranchInfoDefaultingToMain), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferBranchInfoDefaultingToMain> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TransferBranchInfoDefaultingToMain)}");
                defaultingToMain = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.BranchInfoVariant1(
                discriminator?.BranchReason,
                trafficSplit,

                defaultingToMain
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BranchInfoVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTrafficSplit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferBranchInfoTrafficSplit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferBranchInfoTrafficSplit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferBranchInfoTrafficSplit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrafficSplit, typeInfo);
            }
            else if (value.IsDefaultingToMain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferBranchInfoDefaultingToMain), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferBranchInfoDefaultingToMain?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferBranchInfoDefaultingToMain).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DefaultingToMain, typeInfo);
            }
        }
    }
}